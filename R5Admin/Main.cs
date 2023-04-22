using Guna.UI2.WinForms;
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
using System.Windows.Forms.VisualStyles;

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
            NativeF,
            Rcon,
            None
        }

        public R5Rcon rcon = new R5Rcon();
        List<Guna2Button> tabbuttons = new List<Guna2Button>();
        List<UserControl> controls = new List<UserControl>();
        Thread rconthread;

        List<Player> players = new List<Player>();
        int currentplayer = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 595);
            TopText.Text = "Not Connected";

            tabbuttons.Add(ConsoleBtn);
            tabbuttons.Add(PlayersBtn);
            tabbuttons.Add(CommandsBtn);

            ShowTabButtons(false);

            controls.Add(r5Console1);
            controls.Add(playerList1);
            controls.Add(commands1);

            foreach(var c in controls)
            {
                c.Location = new Point(0, 54);
                c.Hide();
            }

            DisconnectBtn.Hide();

            playerList1.r5admin = this;
            r5Console1.r5admin = this;
            commands1.r5admin = this;

            serverSelect1.Show();
            serverSelect1.Location = new Point(0, 54);
            serverSelect1.FillRconList();
            serverSelect1.r5admin = this;
        }

        private void ShowTabButtons(bool show)
        {
            foreach (var button in tabbuttons)
                button.Visible = show;

            DisconnectBtn.Visible = show;
        }

        private void SelectTab(Guna2Button b, UserControl c)
        {
            foreach (var button in tabbuttons)
            {
                if (b == button)
                    button.Checked = true;
                else
                    button.Checked = false;
            }

            foreach (var control in controls)
            {
                if (c == control)
                    control.Visible = true;
                else
                    control.Visible = false;
            }
        }

        public void ClearPlayerList()
        {
            playerList1.NoPlayers.Visible = true;
            playerList1.panellocation = new Point(0, 3);
            playerList1.PlayerPanel.Controls.Clear();
            players.Clear();
            playerList1.playerips.Clear();
            currentplayer = 0;
        }

        public void UpdatePlayerIP(string ip)
        {

            players[currentplayer].IP = ip.Replace(" ", "");

            if (InvokeRequired)
                playerList1.Invoke(new MethodInvoker(() => { playerList1.UpdateIP(ip.Replace(" ", ""), currentplayer); }));
            else
                playerList1.UpdateIP(ip.Replace(" ", ""), currentplayer);

            currentplayer++;
        }

        public void UpdatePlayers(string message)
        {
            string[] split = message.Split(' ');

            if (split.Length < 9)
                return;

            Player p = new Player
            {
                ID = split[1],
                NAME = split[2].Replace("\"", ""),
                UID = split[3]
            };

            players.Add(p);

            if (InvokeRequired)
                playerList1.Invoke(new MethodInvoker(() => { playerList1.AddPlayer(p); }));
            else
                playerList1.AddPlayer(p);
        }

        public void UpdateConsole(SvRcon.response sv_response, ConsoleMessageType t)
        {
            if (InvokeRequired)
                r5Console1.ConsoleBox.Invoke(new MethodInvoker(() => { r5Console1.ConsoleBox.AppendText(GetCorrectNativeString(t) + sv_response.ResponseMsg, GetConsoleColor(t)); }));
            else
                r5Console1.ConsoleBox.AppendText(GetCorrectNativeString(t) + sv_response.ResponseMsg, GetConsoleColor(t));
        }

        public void UpdateConsole(string message, ConsoleMessageType t)
        {
            if (InvokeRequired)
                r5Console1.ConsoleBox.Invoke(new MethodInvoker(() => { r5Console1.ConsoleBox.AppendText(GetCorrectNativeString(t) + message + "\n", GetConsoleColor(t)); }));
            else
                r5Console1.ConsoleBox.AppendText(GetCorrectNativeString(t) + message + "\n", GetConsoleColor(t));
        }

        public Color GetConsoleColor(ConsoleMessageType t)
        {
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
                default: return Color.FromArgb(204, 204, 204);
            }
        }

        public string GetCorrectNativeString(ConsoleMessageType t)
        {
            switch (t)
            {
                case ConsoleMessageType.Normal:
                    return "Native(E): ";
                case ConsoleMessageType.Success:
                    return "";
                case ConsoleMessageType.Error:
                    return "(Error): ";
                case ConsoleMessageType.Warn:
                    return "(Warn): ";
                case ConsoleMessageType.NativeR:
                    return "Native(R): ";
                case ConsoleMessageType.NativeS:
                    return "Native(S): ";
                case ConsoleMessageType.NativeF:
                    return "Native(F): ";
                case ConsoleMessageType.Rcon:
                    return "> ";
                default: return "";
            }
        }

        public void ConnectToServer(string name, string ip, string port, string password)
        {
            rcon.m_hForm = this;

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

            TopText.Text = $"Connected: {ip}:{port} | " + name;

            rcon.m_bConnected = true;
            rconthread = new Thread(new ThreadStart(rcon.Runframe));
            rconthread.Start();

            if (!string.IsNullOrEmpty(password))
            {
                rcon.SendCommand(password, "", ClRcon.request_t.ServerdataRequestAuth);
            }
            else
            {
                UpdateConsole("This server is password protected for console access", Main.ConsoleMessageType.Warn);
                UpdateConsole("please use 'pass <password>' to authenticate", Main.ConsoleMessageType.Warn);
            }

            serverSelect1.Hide();
            ShowTabButtons(true);
            SelectTab(ConsoleBtn, r5Console1);
        }

        public void DisconnectFromServer()
        {
            if(rcon.m_hSocket == null || !rcon.m_hSocket.Connected)
            {
                TopText.Text = "Not Connected";
                rconthread.Abort();

                foreach (var c in controls)
                    c.Hide();

                ShowTabButtons(false);

                serverSelect1.Show();
                rcon.m_bConnected = false;
                return;
            }

            TopText.Text = "Not Connected";

            rcon.m_bConnected = false;
            rconthread.Abort();
            rcon.Disconnect();

            foreach (var c in controls)
                c.Hide();

            ShowTabButtons(false);

            serverSelect1.Show();

            r5Console1.ConsoleBox.Text = "";
        }

        public string GetAmountOfPasswordDots(string password)
        {
            string passdots = "";
            for(int i = 0; i < password.Length; i++)
                passdots += "•";

            return passdots;
        }

        public void ExecCommand(string cmd)
        {
            if (string.IsNullOrEmpty(cmd))
                return;

            string[] svSplitString = cmd.Split(' ');
            if (svSplitString[0].ToLower() == "pass")
            {
                UpdateConsole($"{svSplitString[0]} {GetAmountOfPasswordDots(svSplitString[1])}", ConsoleMessageType.Rcon);
                rcon.SendCommand(svSplitString[1], "", ClRcon.request_t.ServerdataRequestAuth);
                return;
            }

            if (svSplitString[0].ToLower() == "set")
            {
                if (svSplitString.Length > 2)
                {
                    UpdateConsole($"{cmd}", ConsoleMessageType.Rcon);
                    rcon.SendCommand(cmd, "", ClRcon.request_t.ServerdataRequestSetvalue);
                    return;
                }
            }

            if(cmd.ToLower() == "disconnect")
            {
                UpdateConsole($"{cmd}", ConsoleMessageType.Rcon);
                DisconnectFromServer();
                return;
            }

            if (cmd.ToLower() == "status")
                ClearPlayerList();

            UpdateConsole($"{cmd}", ConsoleMessageType.Rcon);
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

        private void ConsoleBtn_Click(object sender, EventArgs e)
        {
            SelectTab(ConsoleBtn, r5Console1);
        }

        private void PlayersBtn_Click(object sender, EventArgs e)
        {
            ClearPlayerList();
            ExecCommand("status");
            SelectTab(PlayersBtn, playerList1);
        }

        private void CommandsBtn_Click(object sender, EventArgs e)
        {
            SelectTab(CommandsBtn, commands1);
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
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
    public class SavedServers
    {
        public List<Server> Servers { get; set; }
    }

    public class Server
    {
        public string name { get; set; }
        public string ip { get; set; }
        public string port { get; set; }
        public string pass { get; set; }
    }
}
