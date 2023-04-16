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

        private void ExecCommand(string cmd)
        {
            string[] svSplitString = cmd.Split(' ');
            if (svSplitString[0].ToLower() == "pass")
            {
                r5admin.rcon.SendCommand(svSplitString[1], "", ClRcon.request_t.ServerdataRequestAuth);
            }
            else
            {
                r5admin.rcon.SendCommand(cmd, "", ClRcon.request_t.ServerdataRequestExeccommand);
            }
        }

        private void ChangeMap_Click(object sender, EventArgs e)
        {
            ExecCommand("map " + MapCombo.SelectedItem.ToString());
        }

        private void LaunchPlaylist_Click(object sender, EventArgs e)
        {
            ExecCommand("launchplaylist " + PlaylistCombo.SelectedItem.ToString());
        }

        private void SendCommand_Click(object sender, EventArgs e)
        {
            ExecCommand(CommandTxt.Text);
            CommandTxt.Text = "";
        }

        private void CommandTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecCommand(CommandTxt.Text);
                CommandTxt.Text = "";
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
    }

    public class Maps_Playlists
    {
        public List<string> Maps { get; set; }
        public List<string> Playlists { get; set; }
    }
}
