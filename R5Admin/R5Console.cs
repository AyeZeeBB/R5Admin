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
        public Main r5admin;

        public R5Console()
        {
            InitializeComponent();
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

        private void ConsoleBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            ConsoleBox.SelectionStart = ConsoleBox.Text.Length;
            // scroll it automatically
            ConsoleBox.ScrollToCaret();
        }

        private void ConsoleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
