using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace R5Admin
{
    public partial class R5Console : UserControl
    {
        string jsonPath = Path.GetDirectoryName(Application.ExecutablePath) + "/data/Maps_Playlists.json";
        public Main r5admin;

        public R5Console()
        {
            InitializeComponent();
        }

        public void FillMapsAndPlaylists()
        {
            string json = File.ReadAllText(jsonPath);
            Maps_Playlists mapsplaylists = JsonConvert.DeserializeObject<Maps_Playlists>(json);

            List<string> maps = mapsplaylists.Maps;
            List<string> playlists = mapsplaylists.Playlists;

            MapCombo.Items.Clear();
            PlaylistCombo.Items.Clear();

            foreach (string m in maps )
                MapCombo.Items.Add(m);

            foreach (string p in playlists)
                PlaylistCombo.Items.Add(p);

            PlaylistCombo.SelectedIndex = 0;
            MapCombo.SelectedIndex = 0;
        }

        private void ChangeMap_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("map " + MapCombo.SelectedItem.ToString());
        }

        private void LaunchPlaylist_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("launchplaylist " + PlaylistCombo.SelectedItem.ToString());
        }

        private void SendCommand_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand(CommandTxt.Text);
            CommandTxt.Text = "";
        }

        private void CommandTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                r5admin.ExecCommand(CommandTxt.Text);
                CommandTxt.Text = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            r5admin.DisconnectFromServer();
        }

        private void ConsoleBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            // scroll it automatically
            ConsoleBox.ScrollToCaret();
        }

        private void SetPylonVis_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("sv_pylonvisibility " + PlaylistCombo.SelectedIndex);
        }

        private void svcheats_CheckedChanged(object sender, EventArgs e)
        {
            int onoff = svcheats.Checked ? 1 : 0;
            r5admin.ExecCommand("sv_cheats " + onoff);
        }

        private void checkstatus_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("status");
        }

        private void reloadplaylist_Click(object sender, EventArgs e)
        {
            r5admin.ExecCommand("reloadplaylist");
        }

        private void ConsoleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }

    public class Maps_Playlists
    {
        public List<string> Maps { get; set; }
        public List<string> Playlists { get; set; }
    }
}
