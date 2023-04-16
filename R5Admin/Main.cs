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
            Warn
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

        public void AppendConsole(string message, ConsoleMessageType t)
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
                    return Color.FromArgb(214, 214, 214);
                case ConsoleMessageType.Success:
                    return Color.FromArgb(71, 246, 120);
                case ConsoleMessageType.Error:
                    return Color.FromArgb(246, 71, 75);
                case ConsoleMessageType.Warn:
                    return Color.FromArgb(254, 203, 107);
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
            catch(Exception e)
            {
                MessageBox.Show("Couldnt Connect To Server");
                return;
            }

            TopText.Text = "R5Admin | " + name;

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
                return;
            }

            TopText.Text = "R5Admin | Not Connected";

            rconthread.Abort();
            rcon.Disconnect();
 
            r5Console1.Hide();
            serverSelect1.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rcon != null)
                rcon.Disconnect();

            if(rconthread != null)
                rconthread.Abort();
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
