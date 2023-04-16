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
            AddServerPanel.Parent = this;
            AddServerPanel.Hide();
        }

        string jsonPath = Path.GetDirectoryName(Application.ExecutablePath) + "/data/R5AdminServers.json";
        public Main r5admin;
        public Root Servers = new Root();

        public void FillRconList()
        {
            ServersPanel.Controls.Clear();

            if (File.Exists(jsonPath))
            {

                string json = File.ReadAllText(jsonPath);
                Root R5RconServers = JsonConvert.DeserializeObject<Root>(json);

                Servers = R5RconServers;

                int idx = 0;
                int serverid = 0;
                Point location = new Point(33, 33);
                foreach(Server srv in R5RconServers.Servers)
                {
                    Guna2Panel p = new Guna2Panel();
                    p.Parent = ServersPanel;
                    p.Size = new Size(150, 150);
                    p.Location = location;
                    p.BorderRadius = 2;
                    p.BorderThickness = 2;
                    p.BorderColor = Color.FromArgb(42, 47, 65);

                    Guna2Button connect = new Guna2Button();
                    connect.Parent = p;
                    connect.Size = new Size(121, 30);
                    connect.Location = new Point(0, 120);
                    connect.BorderRadius = 2;
                    connect.Text = "Connect";
                    connect.Animated = true;
                    connect.FillColor = Color.FromArgb(78, 92, 126);
                    connect.Font = new Font("Arial", 8);
                    connect.Click += (s, e) => {
                        r5admin.ConnectToServer(srv.name, srv.ip, srv.port, srv.pass);
                    };

                    Guna2Button delete = new Guna2Button();
                    delete.Parent = p;
                    delete.Size = new Size(30, 30);
                    delete.Location = new Point(120, 120);
                    delete.BorderRadius = 2;
                    delete.Text = "";
                    delete.Animated = true;
                    delete.FillColor = Color.FromArgb(255, 128, 128);
                    delete.Image = Resources.icons8_empty_trash_64;
                    delete.ImageSize = new Size(20, 20);
                    delete.Click += (s, e) => {
                        DeleteServer(srv);
                    };

                    Guna2HtmlLabel name = new Guna2HtmlLabel();
                    name.Parent = p;
                    name.Font = new Font("Arial", 8);
                    name.ForeColor = Color.White;
                    name.Location = new Point(3, 3);
                    name.IsSelectionEnabled = false;
                    name.Text = "Server Name:";

                    Guna2HtmlLabel address = new Guna2HtmlLabel();
                    address.Parent = p;
                    address.Font = new Font("Arial", 8);
                    address.ForeColor = Color.White;
                    address.Location = new Point(3, 62);
                    address.IsSelectionEnabled = false;
                    address.Text = "Server Address:";

                    Guna2HtmlLabel svName = new Guna2HtmlLabel();
                    svName.Parent = p;
                    svName.AutoSize = false;
                    svName.Font = new Font("Arial", 8);
                    svName.ForeColor = Color.White;
                    svName.Location = new Point(3, 19);
                    svName.Size = new Size(144, 31);
                    svName.IsSelectionEnabled = false;
                    svName.Text = srv.name;

                    Guna2HtmlLabel svAddress= new Guna2HtmlLabel();
                    svAddress.Parent = p;
                    svAddress.AutoSize = false;
                    svAddress.Font = new Font("Arial", 8);
                    svAddress.ForeColor = Color.White;
                    svAddress.Location = new Point(3, 78);
                    svAddress.Size = new Size(144, 31);
                    svAddress.IsSelectionEnabled = false;
                    svAddress.Text = $"{srv.ip}:{srv.port}";

                    idx++;
                    serverid++;
                    location.X += 156;
                    if (idx > 4)
                    {
                        idx = 0;
                        location.Y += 156;
                        location.X = 33;
                    }
                }

                Guna2Button add = new Guna2Button();
                add.Parent = ServersPanel;
                add.Size = new Size(150, 150);
                add.Location = location;
                add.BorderRadius = 2;
                add.BorderThickness = 2;
                add.BorderColor = Color.FromArgb(42, 47, 65);
                add.Text = "Add Server";
                add.Image = Resources.icons8_add_64;
                add.ImageSize = new Size(40, 40);
                add.TextOffset = new Point(-30, 30);
                add.Font = new Font("Arial", 9);
                add.Animated = true;
                add.FillColor = Color.FromArgb(27, 28, 48);
                add.TextAlign = HorizontalAlignment.Right;
                add.ImageOffset = new Point(0, -15);
                add.Click += (s, e) => {
                    AddServerPanel.BringToFront();
                    AddServerPanel.Show();
                };
            }
            else
            {
                Guna2Button add = new Guna2Button();
                add.Parent = ServersPanel;
                add.Size = new Size(150, 150);
                add.Location = new Point(33, 33);
                add.BorderRadius = 2;
                add.BorderThickness = 2;
                add.BorderColor = Color.FromArgb(42, 47, 65);
                add.Text = "Add Server";
                add.Image = Resources.icons8_add_64;
                add.ImageSize = new Size(40, 40);
                add.TextOffset = new Point(-30, 30);
                add.Font = new Font("Arial", 9);
                add.Animated = true;
                add.FillColor = Color.FromArgb(27, 28, 48);
                add.TextAlign = HorizontalAlignment.Right;
                add.ImageOffset = new Point(0, -15);
                add.Click += (s, e) => {
                    AddServerPanel.BringToFront();
                    AddServerPanel.Show();
                };
            }
        }

        private void AddServer(string name, string ip, string port, string pass)
        {
            Server srv = new Server();
            srv.name = name;
            srv.ip = ip;
            srv.port = port;
            srv.pass = pass;

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

        private void ServerAddBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ServerNameTxt.Text))
            {
                MessageBox.Show("Please fill in everything");
                return;
            }

            if (string.IsNullOrEmpty(ServerIPTxt.Text) || string.IsNullOrEmpty(ServerPortTxt.Text))
            {
                MessageBox.Show("Please enter both a IP and PORT");
                return;
            }

            try
            {
                R5Rcon rcon = new R5Rcon();
                bool connected = rcon.TestServerConnection(ServerIPTxt.Text, ServerPortTxt.Text);
                if (!connected)
                {
                    MessageBox.Show("Failed to connect: verify IP and PORT");
                    return;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: verify IP and PORT");
                return;
            }

            AddServer(ServerNameTxt.Text, ServerIPTxt.Text, ServerPortTxt.Text, ServerPasswordTxt.Text);

            AddServerPanel.SendToBack();
            AddServerPanel.Hide();

            ServerNameTxt.Text = "";
            ServerIPTxt.Text = "";
            ServerPortTxt.Text = "";
            ServerPasswordTxt.Text = "";
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
    }
}
