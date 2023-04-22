using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace R5Admin
{
    public partial class Commands : UserControl
    {
        public Commands()
        {
            InitializeComponent();
        }

        readonly string MapsPlaylistsJson = Path.GetDirectoryName(Application.ExecutablePath) + "/data/Maps_Playlists.json";
        readonly string CustomTogglesJson = Path.GetDirectoryName(Application.ExecutablePath) + "/data/Custom_Toggles.json";
        public Main r5admin;

        private void Commands_Load(object sender, EventArgs e)
        {
            FillMapsAndPlaylists();
            FillCustomToggles();
        }

        public void FillMapsAndPlaylists()
        {
            if (!File.Exists(MapsPlaylistsJson))
                return;

            string json = File.ReadAllText(MapsPlaylistsJson);
            Maps_Playlists mapsplaylists = JsonConvert.DeserializeObject<Maps_Playlists>(json);

            List<string> maps = mapsplaylists.Maps;
            List<string> playlists = mapsplaylists.Playlists;

            MapCombo.Items.Clear();
            PlaylistCombo.Items.Clear();

            foreach (string m in maps)
                MapCombo.Items.Add(m);

            foreach (string p in playlists)
                PlaylistCombo.Items.Add(p);

            PlaylistCombo.SelectedIndex = 0;
            MapCombo.SelectedIndex = 0;
        }

        public void FillCustomToggles()
        {
            CustomTogglesBox.Controls.Clear();

            if (!File.Exists(CustomTogglesJson))
                return;

            string json = File.ReadAllText(CustomTogglesJson);
            Custom_Toggles customtoggles = JsonConvert.DeserializeObject<Custom_Toggles>(json);

            Point loc = new Point(8, 8);

            foreach(string command in customtoggles.Commands)
            {
                Guna2Panel p = new Guna2Panel
                {
                    Parent = CustomTogglesBox,
                    Size = new Size(442, 33),
                    Location = loc,
                    BorderRadius = 2,
                    BorderColor = Color.FromArgb(42, 47, 65),
                    FillColor = Color.FromArgb(42, 47, 65)
                };

                Guna2HtmlLabel cmdlbl = new Guna2HtmlLabel
                {
                    Parent = p,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(3, 6),
                    IsSelectionEnabled = false,
                    Text = command
                };

                Guna2ToggleSwitch cmdswitch = new Guna2ToggleSwitch
                {
                    Parent = p,
                    Location = new Point(391, 6),
                    BackColor = Color.FromArgb(42, 47, 65),
                    Size = new Size(44, 21),
                    Animated = true
                };
                cmdswitch.CheckedState.FillColor = Color.FromArgb(42, 195, 103);
                cmdswitch.CheckedState.BorderColor = Color.FromArgb(42, 195, 103);
                cmdswitch.CheckedState.InnerBorderColor = Color.White;
                cmdswitch.CheckedState.InnerColor = Color.White;
                cmdswitch.CheckedState.BorderRadius = 4;
                cmdswitch.CheckedState.InnerBorderRadius = 3;
                cmdswitch.UncheckedState.FillColor = Color.FromArgb(78, 92, 126);
                cmdswitch.UncheckedState.BorderColor = Color.FromArgb(78, 92, 126);
                cmdswitch.UncheckedState.InnerBorderColor = Color.White;
                cmdswitch.UncheckedState.InnerColor = Color.White;
                cmdswitch.UncheckedState.BorderRadius = 4;
                cmdswitch.UncheckedState.InnerBorderRadius = 3;
                cmdswitch.CheckedChanged += (s, e) => {
                    int onoff = cmdswitch.Checked ? 1 : 0;
                    r5admin.ExecCommand($"{command} {onoff}");
                };

                loc.Y += 39;
            }
        }

        private void ChangeMap_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("map " + MapCombo.SelectedItem.ToString());
        }

        private void LaunchPlaylist_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("launchplaylist " + PlaylistCombo.SelectedItem.ToString());
        }

        private void SetPylonVis_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("sv_pylonvisibility " + PylonVisCombo.SelectedIndex);
        }

        private void SetServerName_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("hostname " + ServerNameTxt.Text);
        }

        private void SetServerDesc_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("hostdesc " + ServerDescTxt.Text);
        }

        private void SetCustomNetKey_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("net_setkey " + NetKeyTxt.Text);
        }

        private void GenerateNetKey_Click(object sender, EventArgs e)
        {
            string newkey = GenerateNewNetKey();
            NetKeyTxt.Text = newkey;
            r5admin.ExecCommand("net_setkey " + newkey);
        }

        const string CHAR_SET = "abcdefghijklmnopqursuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        public string GenerateNewNetKey()
        {
            char[] _password = new char[22];
            System.Random _random = new Random();
            int counter;

            for (counter = 0; counter < 22; counter++)
                _password[counter] = CHAR_SET[_random.Next(CHAR_SET.Length - 1)];

            return String.Join(null, _password) + "==";
        }
    }
    public class Maps_Playlists
    {
        public List<string> Maps { get; set; }
        public List<string> Playlists { get; set; }
    }

    public class Custom_Toggles
    {
        public List<string> Commands { get; set; }
    }
}
