using ClRcon;
using Google.Protobuf;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace R5Admin
{
    public class R5Rcon 
    {
        public CConnectedNetConsoleData pData = new CConnectedNetConsoleData();
        public bool m_bConnected = false;

        public void SetConsoleControl(Main form)
        {
            pData.m_hForm = form;
        }

        public void Runframe()
        {
            while (m_bConnected)
            {
                if (pData.m_hSocket != null && pData.m_hSocket.Connected)
                {
                    Thread.Sleep(50);
                    Recv();
                }
            }
        }

        public bool TestServerConnection(string svInAdr, string svInPort)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(svInAdr);
            IPAddress serverAddr = hostInfo.AddressList[0];
            var serverEndPoint = new IPEndPoint(serverAddr, Int32.Parse(svInPort));
            Socket connectionTest = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            connectionTest.Connect(serverEndPoint);
            if(!connectionTest.Connected)
            {
                return false;
            }

            return true;
        }

        public bool Connect(string svInAdr, string svInPort)
        {
            string svFull = $"{svInAdr}:{svInPort}";

            if (!string.IsNullOrEmpty(svInAdr) && !string.IsNullOrEmpty(svInPort))
            {
                var svEndPoint = GetEndPoint(svInAdr, svInPort);
                pData.m_hSocket.Connect(svEndPoint);
            }
            else if (string.IsNullOrEmpty(svInPort))
            {
                pData.m_hForm.UpdateConsole($"No port provided", Main.ConsoleMessageType.Error);
                return false;
            }
            else
            {
                pData.m_hForm.UpdateConsole($"No IP address provided", Main.ConsoleMessageType.Error);
                return false;
            }

            if (!pData.m_hSocket.Connected)
            {
                pData.m_hForm.UpdateConsole($"Failed to connect: verify IP and PORT", Main.ConsoleMessageType.Error);
                return false;
            }

            pData.m_hForm.UpdateConsole($"Connected to: {svFull}", Main.ConsoleMessageType.Success);
            return true;
        }

        public void Disconnect()
        {
            if(pData.m_hSocket != null && pData.m_hSocket.Connected)
            {
                pData.m_hSocket.Disconnect(false);
                pData.m_hForm.UpdateConsole("Disconnected", Main.ConsoleMessageType.Warn);
            }
        }

        public void SendCommand(string svReqBuf, string svReqVal, request_t request_t)
        {
            byte[] svCommand = Serialize(svReqBuf, svReqVal, request_t);
            Send(svCommand);
        }

        public void Send(byte[] svMessage)
        {
            byte[] messageBytes = svMessage;

            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(IPAddress.HostToNetworkOrder(messageBytes.Length));
                writer.Write(messageBytes);

                SocketError error;
                int bytesSent = pData.m_hSocket.Send(stream.ToArray(), 0, (int)stream.Length, SocketFlags.None, out error);

                if (error != SocketError.Success)
                    pData.m_hForm.UpdateConsole($"Failed to send message {error}", Main.ConsoleMessageType.Error);
            }
        }

        public void Recv()
        {
            const int szRecvBufSize = 1024;
            byte[] szRecvBuf = new byte[szRecvBufSize];

            {
                int nPendingLen = pData.m_hSocket.Receive(szRecvBuf, 1, SocketFlags.Peek);
                if (nPendingLen == (int)SocketError.SocketError && pData.m_hSocket.Blocking)
                {
                    return;
                }
                if (nPendingLen <= 0 && pData.m_hSocket.Connected) // EOF or error.
                {
                    pData.m_hSocket.Disconnect(false);
                    pData.m_hForm.UpdateConsole($"Server closed connection", Main.ConsoleMessageType.Warn);
                    return;
                }
            }

            int nReadLen = pData.m_hSocket.Available;

            while (nReadLen > 0)
            {
                int nRecvLen = pData.m_hSocket.Receive(szRecvBuf, Math.Min(szRecvBufSize, nReadLen), SocketFlags.None);
                if (nRecvLen == 0 && pData.m_hSocket.Connected) // Socket was closed.
                {
                    Disconnect();
                    pData.m_hForm.UpdateConsole($"Server closed connection", Main.ConsoleMessageType.Warn);
                    break;
                }
                if (nRecvLen < 0 && !pData.m_hSocket.Blocking)
                {
                    pData.m_hForm.UpdateConsole($"RCON Cmd: recv error", Main.ConsoleMessageType.Error);
                    break;
                }

                nReadLen -= nRecvLen; // Process what we've got.
                this.ProcessBuffer(szRecvBuf, nRecvLen, pData);
            }
        }

        public void ProcessBuffer(byte[] pRecvBuf, int nRecvLen, CConnectedNetConsoleData pData)
        {
            while (nRecvLen > 0)
            {
                if (pData.m_nPayloadLen > 0)
                {
                    if (pData.m_nPayloadRead < pData.m_nPayloadLen)
                    {
                        pData.m_RecvBuffer[pData.m_nPayloadRead++] = pRecvBuf[0];

                        Array.Copy(pRecvBuf, 1, pRecvBuf, 0, nRecvLen - 1);
                        nRecvLen--;
                    }

                    if (pData.m_nPayloadRead == pData.m_nPayloadLen)
                    {
                        this.ProcessMessage(this.Deserialize(Encoding.ASCII.GetString(pData.m_RecvBuffer, 0, pData.m_nPayloadLen)));

                        pData.m_nPayloadLen = 0;
                        pData.m_nPayloadRead = 0;
                    }
                }
                else if (pData.m_nPayloadRead < sizeof(int))
                {
                    pData.m_RecvBuffer[pData.m_nPayloadRead++] = pRecvBuf[0];

                    Array.Copy(pRecvBuf, 1, pRecvBuf, 0, nRecvLen - 1);
                    nRecvLen--;
                }
                else
                {
                    pData.m_nPayloadLen = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(pData.m_RecvBuffer, 0));
                    pData.m_nPayloadRead = 0;

                    if (pData.m_nPayloadLen < 0 || pData.m_nPayloadLen > pData.m_RecvBuffer.Max())
                    {
                        pData.m_hForm.UpdateConsole($"RCON Cmd: sync error ({pData.m_nPayloadLen})", Main.ConsoleMessageType.Error);
                        Disconnect();
                        break;
                    }
                    else
                    {
                        Array.Resize(ref pData.m_RecvBuffer, pData.m_nPayloadLen);
                    }
                }
            }
        }

        public void ProcessMessage(SvRcon.response sv_response)
        {
            switch (sv_response.ResponseType)
            {
                case SvRcon.response_t.ServerdataResponseAuth:
                    {
                        if (!string.IsNullOrEmpty(sv_response.ResponseVal))
                        {
                            long i = long.Parse(sv_response.ResponseVal);
                            if (i == 0) // sv_rcon_sendlogs is not set.
                            {
                                byte[] svLogQuery = Serialize("", "", ClRcon.request_t.ServerdataRequestSendConsoleLog);
                                Send(svLogQuery);
                            }
                        }

                        if (sv_response.ResponseMsg.Contains("Admin password incorrect"))
                        {
                            pData.m_hForm.UpdateConsole(sv_response, Main.ConsoleMessageType.Error);
                            pData.m_hForm.UpdateConsole("please use 'pass <password>' to authenticate", Main.ConsoleMessageType.Warn);
                        }
                        else if (sv_response.ResponseMsg.Contains("This server is password protected for console access"))
                        {
                            pData.m_hForm.UpdateConsole("This server is password protected for console access", Main.ConsoleMessageType.Warn);
                            pData.m_hForm.UpdateConsole("please use 'pass <password>' to authenticate", Main.ConsoleMessageType.Warn);
                        }
                        else
                            pData.m_hForm.UpdateConsole(sv_response, Main.ConsoleMessageType.Success);

                        break;
                    }
                case SvRcon.response_t.ServerdataResponseConsoleLog:
                    {
                        pData.m_hForm.UpdateConsole(sv_response, GetCorrectConsoleType(sv_response.ResponseMsg));
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public byte[] Serialize(string svReqBuf, string svReqVal, request_t request_t)
        {
            var cl_request = new ClRcon.request
            {
                MessageID = -1,
                RequestType = request_t
            };

            switch (request_t)
            {
                case request_t.ServerdataRequestSetvalue:
                case request_t.ServerdataRequestAuth:
                    {
                        cl_request.RequestMsg = svReqBuf;
                        cl_request.RequestVal = svReqVal;
                        break;
                    }
                case request_t.ServerdataRequestExeccommand:
                    {
                        cl_request.RequestMsg = svReqBuf;
                        break;
                    }
            }

            return cl_request.ToByteArray();
        }

        public SvRcon.response Deserialize(string svBuf)
        {
            SvRcon.response sv_response = new SvRcon.response();
            try
            {
                sv_response.MergeFrom(System.Text.Encoding.ASCII.GetBytes(svBuf));
            }
            catch
            {

            }
            return sv_response;
        }

        public Main.ConsoleMessageType GetCorrectConsoleType(string msg)
        {
            if(msg.Contains("Loading pak"))
                return Main.ConsoleMessageType.NativeR;

            if (msg.Contains("Created SERVER VM") || msg.Contains("Published server with token") || msg.Contains("Processing connectionless challenge") || msg.Contains("Enabled persistence for client") || msg.Contains("Unable to communicate") || msg.Contains("hostname: ") || msg.Contains("version : ") || msg.Contains("udp/ip  : ") || msg.Contains("players : "))
                return Main.ConsoleMessageType.NativeS;

            if (msg.Contains("Mounted vpk file"))
                return Main.ConsoleMessageType.NativeF;

            return Main.ConsoleMessageType.Normal;
        }

        public IPEndPoint GetEndPoint(string svInAdr, string svInPort)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(svInAdr);
            IPAddress serverAddr = hostInfo.AddressList[0];
            var serverEndPoint = new IPEndPoint(serverAddr, Int32.Parse(svInPort));
            pData.m_hSocket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
            return serverEndPoint;
        }
    }

    public class CConnectedNetConsoleData
    {
        public Socket m_hSocket;
        public Main m_hForm;
        public int m_nPayloadLen = 0;   // Num bytes for this message.
        public int m_nPayloadRead = 0;  // Num read bytes from input buffer.
        public int m_nFailedAttempts = 0; // Num failed authentication attempts.
        public int m_nIgnoredMessage = 0; // Count how many times client ignored the no-auth message.
        public bool m_bValidated = false;      // Revalidates netconsole if false.
        public bool m_bAuthorized = false;     // Set to true after successful netconsole auth.
        public bool m_bInputOnly = false;      // If set, don't send spew to this net console.
        public byte[] m_RecvBuffer = new byte[1024];
    }
}
