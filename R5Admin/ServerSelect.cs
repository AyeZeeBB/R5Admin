using Guna.UI2.WinForms;
using Newtonsoft.Json;
using R5Admin.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace R5Admin
{
    public partial class ServerSelect : UserControl
    {
        public ServerSelect()
        {
            InitializeComponent();
        }

        readonly string jsonPath = Path.GetDirectoryName(Application.ExecutablePath) + "/data/R5AdminServers.json";
        public Main r5admin;
        public SavedServers Servers = new SavedServers();

        public void FillRconList()
        {
            ServersPanel.Controls.Clear();

            if (File.Exists(jsonPath))
            {

                string json = File.ReadAllText(jsonPath);
                SavedServers R5RconServers = JsonConvert.DeserializeObject<SavedServers>(json);

                Servers = R5RconServers;

                int idx = 0;
                int serverid = 0;
                Point location = new Point(33, 33);
                foreach(Server srv in R5RconServers.Servers)
                {
                    Guna2Panel p = new Guna2Panel
                    {
                        Parent = ServersPanel,
                        Size = new Size(150, 150),
                        Location = location,
                        BorderRadius = 2,
                        BorderThickness = 2,
                        BorderColor = Color.FromArgb(42, 47, 65)
                    };

                    Guna2Button connect = new Guna2Button
                    {
                        Parent = p,
                        Size = new Size(121, 30),
                        Location = new Point(0, 120),
                        BorderRadius = 2,
                        Text = "Connect",
                        Animated = true,
                        FillColor = Color.FromArgb(78, 92, 126),
                        Font = new Font("Arial", 8)
                    };
                    connect.Click += (s, e) => {
                        r5admin.ConnectToServer(srv.name, srv.ip, srv.port, srv.pass);
                    };

                    Guna2Button delete = new Guna2Button
                    {
                        Parent = p,
                        Size = new Size(30, 30),
                        Location = new Point(120, 120),
                        BorderRadius = 2,
                        Text = "",
                        Animated = true,
                        FillColor = Color.FromArgb(255, 128, 128),
                        Image = Resources.icons8_empty_trash_64,
                        ImageSize = new Size(20, 20)
                    };
                    delete.Click += (s, e) => {
                        DeleteServer(srv);
                    };

                    Guna2HtmlLabel name = new Guna2HtmlLabel
                    {
                        Parent = p,
                        Font = new Font("Arial", 8),
                        ForeColor = Color.White,
                        Location = new Point(3, 3),
                        IsSelectionEnabled = false,
                        Text = "Server Name:"
                    };

                    Guna2HtmlLabel address = new Guna2HtmlLabel
                    {
                        Parent = p,
                        Font = new Font("Arial", 8),
                        ForeColor = Color.White,
                        Location = new Point(3, 62),
                        IsSelectionEnabled = false,
                        Text = "Server Address:"
                    };

                    Guna2HtmlLabel svName = new Guna2HtmlLabel
                    {
                        Parent = p,
                        AutoSize = false,
                        Font = new Font("Arial", 8),
                        ForeColor = Color.White,
                        Location = new Point(3, 19),
                        Size = new Size(144, 31),
                        IsSelectionEnabled = false,
                        Text = srv.name
                    };

                    Guna2HtmlLabel svAddress = new Guna2HtmlLabel
                    {
                        Parent = p,
                        AutoSize = false,
                        Font = new Font("Arial", 8),
                        ForeColor = Color.White,
                        Location = new Point(3, 78),
                        Size = new Size(144, 31),
                        IsSelectionEnabled = false,
                        Text = $"{srv.ip}:{srv.port}"
                    };

                    idx++;
                    serverid++;
                    location.X += 156;
                    if (idx > 5)
                    {
                        idx = 0;
                        location.Y += 156;
                        location.X = 33;
                    }
                }

                Guna2Button add = new Guna2Button
                {
                    Parent = ServersPanel,
                    Size = new Size(150, 150),
                    Location = location,
                    BorderRadius = 2,
                    BorderThickness = 2,
                    BorderColor = Color.FromArgb(42, 47, 65),
                    Text = "Add Server",
                    Image = Resources.icons8_add_64,
                    ImageSize = new Size(40, 40),
                    TextOffset = new Point(-30, 30),
                    Font = new Font("Arial", 9),
                    Animated = true,
                    FillColor = Color.FromArgb(27, 28, 48),
                    TextAlign = HorizontalAlignment.Right,
                    ImageOffset = new Point(0, -15)
                };
                add.Click += (s, e) => {
                    AddServerPanel.BringToFront();
                    AddServerPanel.Show();
                };
            }
            else
            {
                Guna2Button add = new Guna2Button
                {
                    Parent = ServersPanel,
                    Size = new Size(150, 150),
                    Location = new Point(33, 33),
                    BorderRadius = 2,
                    BorderThickness = 2,
                    BorderColor = Color.FromArgb(42, 47, 65),
                    Text = "Add Server",
                    Image = Resources.icons8_add_64,
                    ImageSize = new Size(40, 40),
                    TextOffset = new Point(-30, 30),
                    Font = new Font("Arial", 9),
                    Animated = true,
                    FillColor = Color.FromArgb(27, 28, 48),
                    TextAlign = HorizontalAlignment.Right,
                    ImageOffset = new Point(0, -15)
                };
                add.Click += (s, e) => {
                    AddServerPanel.BringToFront();
                    AddServerPanel.Show();
                };
            }
        }

        private void AddServer(string name, string ip, string port, string pass)
        {
            Server srv = new Server
            {
                name = name,
                ip = ip,
                port = port,
                pass = pass
            };

            Servers.Servers.Add(srv);

            string output = JsonConvert.SerializeObject(Servers, Formatting.Indented);
            File.WriteAllText(jsonPath, output);
            
            FillRconList();
        }

        private void DeleteServer(Server srv)
        {
            Servers.Servers.Remove(srv);

            string output = JsonConvert.SerializeObject(Servers, Formatting.Indented);
            File.WriteAllText(jsonPath, output);

            FillRconList();
        }

        private bool IsValidIP(string ip)
        {
            try
            {
                if (ip.Count(c => c == '.') == 3)
                {
                    bool flag = IPAddress.TryParse(ip, out IPAddress IP);
                    if (flag)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void ShowAddServerError(string message, Main.ConsoleMessageType t)
        {
            AddServerError.Show();
            AddServerError.Text = message;
            AddServerError.ForeColor = r5admin.GetConsoleColor(t);
        }

        private void ServerAddBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ServerNameTxt.Text))
            {
                ShowAddServerError("A server name is required.", Main.ConsoleMessageType.Error);
                return;
            }

            if (string.IsNullOrEmpty(ServerIPTxt.Text))
            {
                ShowAddServerError("A ip address is required.", Main.ConsoleMessageType.Error);
                return;
            }

            if (string.IsNullOrEmpty(ServerPortTxt.Text))
            {
                ShowAddServerError("A port is required.", Main.ConsoleMessageType.Error);
                return;
            }

            if (!IsValidIP(ServerIPTxt.Text))
            {
                ShowAddServerError($"{ServerIPTxt.Text} is not a valid IP address", Main.ConsoleMessageType.Error);
                return;
            }

            ShowAddServerError($"Testing Server Connection...", Main.ConsoleMessageType.Warn);
            try
            {
                R5Rcon rcon = new R5Rcon();
                bool connected = TestServerConnection(ServerIPTxt.Text, ServerPortTxt.Text);
                if (!connected)
                {
                    ShowAddServerError($"Failed to connect during connection test.", Main.ConsoleMessageType.Warn);
                    DialogResult dialogResult = MessageBox.Show("Failed to connect during connection test.\n\nDo you want to add this server anyways?", "Connection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            } 
            catch
            {
                ShowAddServerError($"Failed to connect during connection test.", Main.ConsoleMessageType.Warn);
                DialogResult dialogResult = MessageBox.Show("Failed to connect during connection test.\n\nDo you want to add this server anyways?", "Connection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            AddServer(ServerNameTxt.Text, ServerIPTxt.Text, ServerPortTxt.Text, ServerPasswordTxt.Text);

            AddServerPanel.SendToBack();
            AddServerPanel.Hide();

            ServerNameTxt.Text = "";
            ServerIPTxt.Text = "";
            ServerPortTxt.Text = "";
            ServerPasswordTxt.Text = "";
            AddServerError.Visible = false;
        }

        public bool TestServerConnection(string svInAdr, string svInPort)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(svInAdr);
            IPAddress serverAddr = hostInfo.AddressList[0];
            var serverEndPoint = new IPEndPoint(serverAddr, Int32.Parse(svInPort));
            Socket connectionTest = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            connectionTest.Connect(serverEndPoint);
            if (!connectionTest.Connected)
            {
                return false;
            }

            return true;
        }

        private void ServerCancelBtn_Click(object sender, EventArgs e)
        {
            AddServerPanel.SendToBack();
            AddServerPanel.Hide();

            ServerNameTxt.Text = "";
            ServerIPTxt.Text = "";
            ServerPortTxt.Text = "";
            ServerPasswordTxt.Text = "";
        }

        private void ServerIPTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '[') && (e.KeyChar != ']') && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
        }

        private void ServerPortTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ServerSelect_Load(object sender, EventArgs e)
        {
            AddServerPanel.Hide();
            AddServerPanel.Location = new Point(0, 0);
            ServersPanel.Location = new Point(0, 0);
        }
    }
}
