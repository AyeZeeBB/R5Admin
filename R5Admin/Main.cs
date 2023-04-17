using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Admin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public enum ConsoleMessageType
        {
            Normal,
            Success,
            Error,
            Warn,
            NativeR,
            NativeS,
            NativeF
        }

        public R5Rcon rcon = new R5Rcon();
        Thread rconthread;

        private void Main_Load(object sender, EventArgs e)
        {
            TopText.Text = "R5Admin | Not Connected";
            r5Console1.Hide();
            r5Console1.Location = new Point(0, 30);
            r5Console1.FillMapsAndPlaylists();
            r5Console1.r5admin = this;

            serverSelect1.Show();
            serverSelect1.Location = new Point(0, 30);
            serverSelect1.FillRconList();
            serverSelect1.r5admin = this;
        }

        public void UpdateConsole(SvRcon.response sv_response, ConsoleMessageType t)
        {
            if (InvokeRequired)
                r5Console1.ConsoleBox.Invoke(new MethodInvoker(() => { r5Console1.ConsoleBox.AppendText(sv_response.ResponseMsg, GetConsoleColor(t)); }));
            else
                r5Console1.ConsoleBox.AppendText(sv_response.ResponseMsg, GetConsoleColor(t));
        }

        public void UpdateConsole(string message, ConsoleMessageType t)
        {
            if (InvokeRequired)
                r5Console1.ConsoleBox.Invoke(new MethodInvoker(() => { r5Console1.ConsoleBox.AppendText(message + "\n", GetConsoleColor(t)); }));
            else
                r5Console1.ConsoleBox.AppendText(message + "\n", GetConsoleColor(t));
        }

        public Color GetConsoleColor(ConsoleMessageType t)
        {
            Color c = Color.FromArgb(214, 214, 214);

            switch(t)
            {
                case ConsoleMessageType.Normal:
                    return Color.FromArgb(204, 204, 204);
                case ConsoleMessageType.Success:
                    return Color.FromArgb(71, 246, 120);
                case ConsoleMessageType.Error:
                    return Color.FromArgb(246, 71, 75);
                case ConsoleMessageType.Warn:
                    return Color.FromArgb(254, 203, 107);
                case ConsoleMessageType.NativeR:
                    return Color.FromArgb(92, 181, 89);
                case ConsoleMessageType.NativeS:
                    return Color.FromArgb(59, 120, 218);
                case ConsoleMessageType.NativeF:
                    return Color.FromArgb(95, 209, 209);
            }

            return c;
        }

        public void ConnectToServer(string name, string ip, string port, string password)
        {
            rcon.SetConsoleControl(this);

            try
            {
                bool connected = rcon.Connect(ip, port);
                if (!connected)
                {
                    MessageBox.Show("Couldnt Connect To Server");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Couldnt Connect To Server");
                return;
            }

            TopText.Text = $"R5Admin | Connected: {ip}:{port} | " + name;

            rcon.m_bConnected = true;
            rconthread = new Thread(new ThreadStart(rcon.Runframe));
            rconthread.Start();

            rcon.SendCommand(password, "", ClRcon.request_t.ServerdataRequestAuth);

            serverSelect1.Hide();
            r5Console1.Show();
        }

        public void DisconnectFromServer()
        {
            if(rcon.pData.m_hSocket == null || !rcon.pData.m_hSocket.Connected)
            {
                TopText.Text = "R5Admin | Not Connected";
                rconthread.Abort();
                r5Console1.Hide();
                serverSelect1.Show();
                rcon.m_bConnected = false;
                return;
            }

            TopText.Text = "R5Admin | Not Connected";

            rcon.m_bConnected = false;
            rconthread.Abort();
            rcon.Disconnect();
 
            r5Console1.Hide();
            serverSelect1.Show();

            r5Console1.ConsoleBox.Text = "";
        }

        public void ExecCommand(string cmd)
        {
            string[] svSplitString = cmd.Split(' ');
            if (svSplitString[0].ToLower() == "pass")
            {
                rcon.SendCommand(svSplitString[1], "", ClRcon.request_t.ServerdataRequestAuth);
                return;
            }

            if (svSplitString[0].ToLower() == "set")
            {
                if (svSplitString.Length > 2)
                {
                    rcon.SendCommand(cmd, "", ClRcon.request_t.ServerdataRequestSetvalue);
                    return;
                }
            }

            if(cmd.ToLower() == "disconnect")
            {
                DisconnectFromServer();
                return;
            }

            rcon.SendCommand(cmd, "", ClRcon.request_t.ServerdataRequestExeccommand);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            rcon.m_bConnected = false;

            if (rcon != null)
                rcon.Disconnect();

            if(rconthread != null)
                rconthread.Abort();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            rcon.m_bConnected = false;

            if (rcon != null)
                rcon.Disconnect();

            if (rconthread != null)
                rconthread.Abort();

            Application.Exit();
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    public class ConsoleMessageType
    {
        public Color Normal = Color.FromArgb(254, 203, 107);
        public Color Error = Color.FromArgb(246, 71, 75);
        public Color Warn = Color.FromArgb(254, 203, 107);
    }
}
