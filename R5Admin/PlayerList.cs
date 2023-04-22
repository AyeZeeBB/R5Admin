using Guna.UI2.WinForms;
using R5Admin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace R5Admin
{
    public partial class PlayerList : UserControl
    {
        public PlayerList()
        {
            InitializeComponent();
        }

        public Main r5admin;
        public Size panelsize = new Size(934, 39);
        public Point panellocation = new Point(0, 3);
        public List<Guna2HtmlLabel> playerips = new List<Guna2HtmlLabel>();

        private void PlayerList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateIP(string ip, int id)
        {
            if(ip.StartsWith("[::ffff:"))
            {
                string[] split = ip.Replace("[::ffff:", "").Split(']');
                playerips[id].Text = split[0];
            }
            else
                playerips[id].Text = ip;
        }

        public void AddPlayer(Player p)
        {
            NoPlayers.Visible = false;

            Guna2Panel panel = new Guna2Panel
            {
                Parent = PlayerPanel,
                Size = panelsize,
                Location = panellocation,
                FillColor = Color.FromArgb(34, 35, 57)
            };
            panel.Location = panellocation;

            Guna2HtmlLabel id = new Guna2HtmlLabel
            {
                Parent = panel,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(27, 9),
                IsSelectionEnabled = true,
                Text = p.ID
            };

            Guna2HtmlLabel name = new Guna2HtmlLabel
            {
                Parent = panel,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(108, 9),
                IsSelectionEnabled = true,
                Text = p.NAME
            };

            Guna2HtmlLabel uid = new Guna2HtmlLabel
            {
                Parent = panel,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(328, 9),
                IsSelectionEnabled = true,
                Text = p.UID
            };

            Guna2HtmlLabel ip = new Guna2HtmlLabel
            {
                Parent = panel,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(529, 9),
                IsSelectionEnabled = true,
                Text = p.UID
            };

            playerips.Add(ip);

            Guna2Button kick = new Guna2Button
            {
                Parent = panel,
                Size = new Size(93, 33),
                Location = new Point(739, 3),
                BorderRadius = 2,
                FillColor = Color.FromArgb(78, 92, 126),
                Text = "Kick",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Animated = true
            };
            kick.Click += (s, e) => {
                r5admin.ExecCommand("sv_kickid " + p.UID);
                r5admin.ExecCommand("status");
            };

            Guna2Button ban = new Guna2Button
            {
                Parent = panel,
                Size = new Size(93, 33),
                Location = new Point(838, 3),
                BorderRadius = 2,
                FillColor = Color.FromArgb(78, 92, 126),
                Text = "Ban",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Animated = true
            };
            ban.Click += (s, e) => {
                r5admin.ExecCommand("sv_banid " + p.UID);
                r5admin.ExecCommand("status");
            };

            panellocation.Y += 45;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("status");
        }
    }

    public class Player
    {
        public string ID = "";
        public string NAME = "";
        public string UID = "";
        public string IP = "";
    }
}
