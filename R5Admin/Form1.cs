using ClRcon;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using SvRcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace R5Admin
{
    public partial class Form1 : Form
    {
        R5Rcon rcon = new R5Rcon();
        Thread rconthread;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateConsole(SvRcon.response sv_response)
        {
            if (InvokeRequired)
                richTextBox1.Invoke(new MethodInvoker(() => { richTextBox1.AppendText(sv_response.ResponseMsg); }));
            else
                richTextBox1.AppendText(sv_response.ResponseMsg);
        }

        public void AppendConsole(string message)
        {
            if (InvokeRequired)
                richTextBox1.Invoke(new MethodInvoker(() => { richTextBox1.AppendText(message + "\n"); }));
            else
                richTextBox1.AppendText(message + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rconthread = new Thread(new ThreadStart(rcon.Runframe));
            rconthread.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string[] svSplitString = textBox1.Text.Split(' ');
                if (svSplitString[0].ToLower() == "connect")
                {
                    string[] svAdrPort = svSplitString[1].Split(':');
                    rcon.Connect(svAdrPort[0], svAdrPort[1]);
                }
                else if (svSplitString[0].ToLower() == "pass")
                {
                    rcon.SendCommand(svSplitString[1], "", ClRcon.request_t.ServerdataRequestAuth);
                }
                else
                {
                    rcon.SendCommand(textBox1.Text, "", ClRcon.request_t.ServerdataRequestExeccommand);
                }

                textBox1.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rcon.Disconnect();
            rconthread.Abort();
        }
    }

    public class Root
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
