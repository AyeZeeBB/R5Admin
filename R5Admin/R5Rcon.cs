using ClRcon;
using Google.Protobuf;
using System;
using System.Collections.Generic;
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
        public bool m_bConnected = false;
        public Main m_hForm;
        public Socket m_hSocket;

        public void Runframe()
        {
            while (m_bConnected)
            {
                if (m_hSocket != null && m_hSocket.Connected)
                {
                    Thread.Sleep(50);
                    Recv();
                }
            }
        }

        public bool Connect(string svInAdr, string svInPort)
        {
            string svFull = $"{svInAdr}:{svInPort}";

            if (!string.IsNullOrEmpty(svInAdr) && !string.IsNullOrEmpty(svInPort))
            {
                var svEndPoint = GetEndPoint(svInAdr, svInPort);
                m_hSocket.Connect(svEndPoint);
            }
            else if (string.IsNullOrEmpty(svInPort))
            {
                m_hForm.UpdateConsole($"No port provided", Main.ConsoleMessageType.Error);
                return false;
            }
            else
            {
                m_hForm.UpdateConsole($"No IP address provided", Main.ConsoleMessageType.Error);
                return false;
            }

            if (!m_hSocket.Connected)
            {
                m_hForm.UpdateConsole($"Failed to connect: verify IP and PORT", Main.ConsoleMessageType.Error);
                return false;
            }

            m_hForm.UpdateConsole($"Connected to: {svFull}", Main.ConsoleMessageType.Success);
            return true;
        }

        public void Disconnect()
        {
            if (m_hSocket != null && m_hSocket.Connected)
            {
                m_hSocket.Disconnect(false);
                m_hForm.UpdateConsole("Disconnected", Main.ConsoleMessageType.Warn);
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

                int bytesSent = m_hSocket.Send(stream.ToArray(), 0, (int)stream.Length, SocketFlags.None, out SocketError error);

                if (error != SocketError.Success)
                    m_hForm.UpdateConsole($"Failed to send message {error}", Main.ConsoleMessageType.Error);
            }
        }

        public void Recv()
        {
            byte[] szRecvBuf = new byte[1024];
            CConnectedNetConsoleData pData = new CConnectedNetConsoleData();

            {
                int nPendingLen = m_hSocket.Receive(szRecvBuf, sizeof(char), SocketFlags.Peek);
                if (nPendingLen == (int)SocketError.SocketError && m_hSocket.Blocking)
                {
                    return;
                }
                if (nPendingLen <= 0 && m_hSocket.Connected) // EOF or error.
                {
                    m_hSocket.Disconnect(false);
                    m_hForm.UpdateConsole($"Server closed connection", Main.ConsoleMessageType.Warn);
                    return;
                }
            }

            int nReadLen = m_hSocket.Available;

            while (nReadLen > 0)
            {
                int nRecvLen = m_hSocket.Receive(szRecvBuf, Math.Min(szRecvBuf.Length, nReadLen), SocketFlags.None);
                if (nRecvLen == 0 && m_hSocket.Connected) // Socket was closed.
                {
                    Disconnect();
                    m_hForm.UpdateConsole($"Server closed connection", Main.ConsoleMessageType.Warn);
                    break;
                }
                if (nRecvLen < 0 && !m_hSocket.Blocking)
                {
                    m_hForm.UpdateConsole($"RCON Cmd: recv error", Main.ConsoleMessageType.Error);
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
                        this.ProcessMessage(this.Deserialize(pData.m_RecvBuffer));

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

                    //if (pData.m_nPayloadLen < 0 || pData.m_nPayloadLen > pData.m_RecvBuffer.Max())
                    //{
                    //pData.m_hForm.UpdateConsole($"RCON Cmd: sync error ({pData.m_nPayloadLen})", Main.ConsoleMessageType.Error);
                    //Disconnect();
                    //break;
                    //}
                    //else
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
                            m_hForm.UpdateConsole(sv_response, Main.ConsoleMessageType.Error);
                            m_hForm.UpdateConsole("please use 'pass <password>' to authenticate", Main.ConsoleMessageType.Warn);
                        }
                        else if (sv_response.ResponseMsg.Contains("This server is password protected for console access"))
                        {
                            m_hForm.UpdateConsole("This server is password protected for console access", Main.ConsoleMessageType.Warn);
                            m_hForm.UpdateConsole("please use 'pass <password>' to authenticate", Main.ConsoleMessageType.Warn);
                        }
                        else
                            m_hForm.UpdateConsole(sv_response, Main.ConsoleMessageType.Success);

                        break;
                    }
                case SvRcon.response_t.ServerdataResponseConsoleLog:
                    {
                        m_hForm.UpdateConsole(sv_response, GetCorrectConsoleType(sv_response.ResponseMsg));

                        if (sv_response.ResponseMsg.StartsWith("# "))
                        {
                            for (int i = 1; i < 64; i++)
                            {
                                if (sv_response.ResponseMsg.StartsWith("# " + i))
                                {
                                    m_hForm.UpdatePlayers(sv_response.ResponseMsg);
                                    break;
                                }
                            }
                        }

                        if (sv_response.ResponseMsg.StartsWith(" ["))
                            m_hForm.UpdatePlayerIP(sv_response.ResponseMsg);
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

        public SvRcon.response Deserialize(byte[] svBuf)
        {
            SvRcon.response sv_response = new SvRcon.response();

            try
            {
                sv_response.MergeFrom(svBuf);
            }
            catch (Exception ex)
            {
                m_hForm.UpdateConsole(ex.Message, Main.ConsoleMessageType.Error);
            }
            return sv_response;
        }

        readonly string[] NativeR_Contains_Strings =
        {
            "Loading pak"
        };

        readonly string[] NativeF_Contains_Strings =
        {
            "Mounted vpk file"
        };

        readonly string[] NativeS_Contains_Strings = {
            "Created SERVER VM",
            "Published server with token",
            "Processing connectionless challenge",
            "Enabled persistence for client",
            "Unable to communicate",
            "hostname: ",
            "version : ",
            "udp/ip  : ",
            "players : "
        };

        readonly string[] NativeS_StartsWith_Strings =
        {
            "userid name",
            " adr",
            "#end",
            "# ",
            " ["
        };

        public Main.ConsoleMessageType GetCorrectConsoleType(string msg)
        {
            //Native(R) Strings
            foreach (string s in NativeR_Contains_Strings)
                if (msg.Contains(s))
                    return Main.ConsoleMessageType.NativeR;

            //Native(S) Strings
            foreach (string s in NativeS_Contains_Strings)
                if(msg.Contains(s))
                    return Main.ConsoleMessageType.NativeS;

            foreach (string s in NativeS_StartsWith_Strings)
                if (msg.StartsWith(s))
                    return Main.ConsoleMessageType.NativeS;

            //Native(F) Strings
            foreach (string s in NativeF_Contains_Strings)
                if (msg.Contains(s))
                    return Main.ConsoleMessageType.NativeF;

            if (string.IsNullOrEmpty(msg) || msg.StartsWith("\n"))
                return Main.ConsoleMessageType.None;

            return Main.ConsoleMessageType.Normal;
        }

        public IPEndPoint GetEndPoint(string svInAdr, string svInPort)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(svInAdr);
            IPAddress serverAddr = hostInfo.AddressList[0];
            var serverEndPoint = new IPEndPoint(serverAddr, Int32.Parse(svInPort));
            m_hSocket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
            return serverEndPoint;
        }
    }

    public class CConnectedNetConsoleData
    {
        public int m_nPayloadLen = 0;   // Num bytes for this message.
        public int m_nPayloadRead = 0;  // Num read bytes from input buffer.
        public byte[] m_RecvBuffer = new byte[sizeof(UInt32)]; // Reserve enough for length-prefix.
    }
}
