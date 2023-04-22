namespace R5Admin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DisconnectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ConsoleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CommandsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlayersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TopText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Min = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.commands1 = new R5Admin.Commands();
            this.playerList1 = new R5Admin.PlayerList();
            this.r5Console1 = new R5Admin.R5Console();
            this.serverSelect1 = new R5Admin.ServerSelect();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.TopPanel.Controls.Add(this.guna2HtmlLabel1);
            this.TopPanel.Controls.Add(this.DisconnectBtn);
            this.TopPanel.Controls.Add(this.ConsoleBtn);
            this.TopPanel.Controls.Add(this.CommandsBtn);
            this.TopPanel.Controls.Add(this.PlayersBtn);
            this.TopPanel.Controls.Add(this.TopText);
            this.TopPanel.Controls.Add(this.Min);
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1000, 54);
            this.TopPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(5, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 24);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "R5Admin";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Animated = true;
            this.DisconnectBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.DisconnectBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.DisconnectBtn.CheckedState.Parent = this.DisconnectBtn;
            this.DisconnectBtn.CustomImages.Parent = this.DisconnectBtn;
            this.DisconnectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.DisconnectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.White;
            this.DisconnectBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.DisconnectBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.DisconnectBtn.HoverState.Parent = this.DisconnectBtn;
            this.DisconnectBtn.Image = global::R5Admin.Properties.Resources.icons8_disconnected_48;
            this.DisconnectBtn.Location = new System.Drawing.Point(750, 12);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.DisconnectBtn.ShadowDecoration.Parent = this.DisconnectBtn;
            this.DisconnectBtn.Size = new System.Drawing.Size(130, 29);
            this.DisconnectBtn.TabIndex = 8;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConsoleBtn
            // 
            this.ConsoleBtn.Animated = true;
            this.ConsoleBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.ConsoleBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.ConsoleBtn.CheckedState.Parent = this.ConsoleBtn;
            this.ConsoleBtn.CustomImages.Parent = this.ConsoleBtn;
            this.ConsoleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleBtn.ForeColor = System.Drawing.Color.White;
            this.ConsoleBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.ConsoleBtn.HoverState.Parent = this.ConsoleBtn;
            this.ConsoleBtn.Image = global::R5Admin.Properties.Resources.icons8_terminal_48;
            this.ConsoleBtn.Location = new System.Drawing.Point(400, 12);
            this.ConsoleBtn.Name = "ConsoleBtn";
            this.ConsoleBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBtn.ShadowDecoration.Parent = this.ConsoleBtn;
            this.ConsoleBtn.Size = new System.Drawing.Size(104, 29);
            this.ConsoleBtn.TabIndex = 7;
            this.ConsoleBtn.Text = "Console";
            this.ConsoleBtn.Click += new System.EventHandler(this.ConsoleBtn_Click);
            // 
            // CommandsBtn
            // 
            this.CommandsBtn.Animated = true;
            this.CommandsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.CommandsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.CommandsBtn.CheckedState.Parent = this.CommandsBtn;
            this.CommandsBtn.CustomImages.Parent = this.CommandsBtn;
            this.CommandsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandsBtn.ForeColor = System.Drawing.Color.White;
            this.CommandsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandsBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.CommandsBtn.HoverState.Parent = this.CommandsBtn;
            this.CommandsBtn.Image = global::R5Admin.Properties.Resources.icons8_clock_48;
            this.CommandsBtn.Location = new System.Drawing.Point(619, 12);
            this.CommandsBtn.Name = "CommandsBtn";
            this.CommandsBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandsBtn.ShadowDecoration.Parent = this.CommandsBtn;
            this.CommandsBtn.Size = new System.Drawing.Size(125, 29);
            this.CommandsBtn.TabIndex = 6;
            this.CommandsBtn.Text = "Commands";
            this.CommandsBtn.Click += new System.EventHandler(this.CommandsBtn_Click);
            // 
            // PlayersBtn
            // 
            this.PlayersBtn.Animated = true;
            this.PlayersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.PlayersBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlayersBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.PlayersBtn.CheckedState.Parent = this.PlayersBtn;
            this.PlayersBtn.CustomImages.Parent = this.PlayersBtn;
            this.PlayersBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlayersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersBtn.ForeColor = System.Drawing.Color.White;
            this.PlayersBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlayersBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.PlayersBtn.HoverState.Parent = this.PlayersBtn;
            this.PlayersBtn.Image = global::R5Admin.Properties.Resources.icons8_people_48;
            this.PlayersBtn.Location = new System.Drawing.Point(510, 12);
            this.PlayersBtn.Name = "PlayersBtn";
            this.PlayersBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlayersBtn.ShadowDecoration.Parent = this.PlayersBtn;
            this.PlayersBtn.Size = new System.Drawing.Size(103, 29);
            this.PlayersBtn.TabIndex = 5;
            this.PlayersBtn.Text = "Players";
            this.PlayersBtn.Click += new System.EventHandler(this.PlayersBtn_Click);
            // 
            // TopText
            // 
            this.TopText.AutoSize = false;
            this.TopText.BackColor = System.Drawing.Color.Transparent;
            this.TopText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TopText.ForeColor = System.Drawing.Color.White;
            this.TopText.IsSelectionEnabled = false;
            this.TopText.Location = new System.Drawing.Point(5, 29);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(389, 16);
            this.TopText.TabIndex = 3;
            this.TopText.Text = "R5Admin";
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Min.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Min.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Min.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.Min.HoverState.Parent = this.Min;
            this.Min.IconColor = System.Drawing.Color.White;
            this.Min.Location = new System.Drawing.Point(924, 12);
            this.Min.Name = "Min";
            this.Min.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Min.ShadowDecoration.Parent = this.Min;
            this.Min.Size = new System.Drawing.Size(29, 29);
            this.Min.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Exit.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(959, 12);
            this.Exit.Name = "Exit";
            this.Exit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopPanel;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.TopText;
            // 
            // commands1
            // 
            this.commands1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.commands1.Location = new System.Drawing.Point(924, 151);
            this.commands1.Name = "commands1";
            this.commands1.Size = new System.Drawing.Size(1000, 539);
            this.commands1.TabIndex = 4;
            // 
            // playerList1
            // 
            this.playerList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.playerList1.Location = new System.Drawing.Point(924, 283);
            this.playerList1.Name = "playerList1";
            this.playerList1.Size = new System.Drawing.Size(1000, 539);
            this.playerList1.TabIndex = 3;
            // 
            // r5Console1
            // 
            this.r5Console1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.r5Console1.Location = new System.Drawing.Point(924, 519);
            this.r5Console1.Name = "r5Console1";
            this.r5Console1.Size = new System.Drawing.Size(1000, 539);
            this.r5Console1.TabIndex = 2;
            // 
            // serverSelect1
            // 
            this.serverSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.serverSelect1.Location = new System.Drawing.Point(5, 519);
            this.serverSelect1.Name = "serverSelect1";
            this.serverSelect1.Size = new System.Drawing.Size(997, 546);
            this.serverSelect1.TabIndex = 1;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.guna2HtmlLabel1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 595);
            this.Controls.Add(this.commands1);
            this.Controls.Add(this.playerList1);
            this.Controls.Add(this.r5Console1);
            this.Controls.Add(this.serverSelect1);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "R5Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox Min;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private ServerSelect serverSelect1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel TopText;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button PlayersBtn;
        private Guna.UI2.WinForms.Guna2Button DisconnectBtn;
        private Guna.UI2.WinForms.Guna2Button ConsoleBtn;
        private Guna.UI2.WinForms.Guna2Button CommandsBtn;
        private Commands commands1;
        private PlayerList playerList1;
        private R5Console r5Console1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}