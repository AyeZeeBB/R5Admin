namespace R5Admin
{
    partial class R5Console
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.CommandTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SetPylonVis = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.svcheats = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Disconnect = new Guna.UI2.WinForms.Guna2Button();
            this.LaunchPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.PlaylistCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ChangeMap = new Guna.UI2.WinForms.Guna2Button();
            this.MapCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SendCommand = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.checkstatus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.reloadplaylist = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(3, 3);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(580, 351);
            this.ConsoleBox.TabIndex = 0;
            this.ConsoleBox.Text = "";
            this.ConsoleBox.TextChanged += new System.EventHandler(this.ConsoleBox_TextChanged);
            this.ConsoleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsoleBox_KeyPress);
            // 
            // CommandTxt
            // 
            this.CommandTxt.Animated = true;
            this.CommandTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandTxt.BorderRadius = 2;
            this.CommandTxt.BorderThickness = 0;
            this.CommandTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandTxt.DefaultText = "";
            this.CommandTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CommandTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CommandTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CommandTxt.DisabledState.Parent = this.CommandTxt;
            this.CommandTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CommandTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.CommandTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.CommandTxt.FocusedState.Parent = this.CommandTxt;
            this.CommandTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.CommandTxt.HoverState.Parent = this.CommandTxt;
            this.CommandTxt.Location = new System.Drawing.Point(236, 376);
            this.CommandTxt.Name = "CommandTxt";
            this.CommandTxt.PasswordChar = '\0';
            this.CommandTxt.PlaceholderText = "Enter Command";
            this.CommandTxt.SelectedText = "";
            this.CommandTxt.ShadowDecoration.Parent = this.CommandTxt;
            this.CommandTxt.Size = new System.Drawing.Size(472, 36);
            this.CommandTxt.TabIndex = 6;
            this.CommandTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandTxt_KeyDown);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 2;
            this.guna2Elipse1.TargetControl = this.ConsoleBox;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.reloadplaylist);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.checkstatus);
            this.guna2Panel1.Controls.Add(this.SetPylonVis);
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.svcheats);
            this.guna2Panel1.Controls.Add(this.Disconnect);
            this.guna2Panel1.Controls.Add(this.LaunchPlaylist);
            this.guna2Panel1.Controls.Add(this.PlaylistCombo);
            this.guna2Panel1.Controls.Add(this.ChangeMap);
            this.guna2Panel1.Controls.Add(this.MapCombo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(220, 430);
            this.guna2Panel1.TabIndex = 7;
            // 
            // SetPylonVis
            // 
            this.SetPylonVis.Animated = true;
            this.SetPylonVis.BorderRadius = 2;
            this.SetPylonVis.CheckedState.Parent = this.SetPylonVis;
            this.SetPylonVis.CustomImages.Parent = this.SetPylonVis;
            this.SetPylonVis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.SetPylonVis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetPylonVis.ForeColor = System.Drawing.Color.White;
            this.SetPylonVis.HoverState.Parent = this.SetPylonVis;
            this.SetPylonVis.Location = new System.Drawing.Point(13, 208);
            this.SetPylonVis.Name = "SetPylonVis";
            this.SetPylonVis.ShadowDecoration.Parent = this.SetPylonVis;
            this.SetPylonVis.Size = new System.Drawing.Size(195, 36);
            this.SetPylonVis.TabIndex = 16;
            this.SetPylonVis.Text = "Set Pylon Visibility";
            this.SetPylonVis.Click += new System.EventHandler(this.SetPylonVis_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.guna2ComboBox1.BorderRadius = 2;
            this.guna2ComboBox1.BorderThickness = 0;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownHeight = 200;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.DropDownWidth = 200;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 25;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Offline",
            "Hidden",
            "Public"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(13, 171);
            this.guna2ComboBox1.MaxDropDownItems = 5;
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(195, 31);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 15;
            // 
            // svcheats
            // 
            this.svcheats.AutoSize = true;
            this.svcheats.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.svcheats.CheckedState.BorderRadius = 2;
            this.svcheats.CheckedState.BorderThickness = 0;
            this.svcheats.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.svcheats.ForeColor = System.Drawing.Color.White;
            this.svcheats.Location = new System.Drawing.Point(13, 328);
            this.svcheats.Name = "svcheats";
            this.svcheats.Size = new System.Drawing.Size(75, 17);
            this.svcheats.TabIndex = 13;
            this.svcheats.Text = "sv_cheats";
            this.svcheats.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.svcheats.UncheckedState.BorderRadius = 2;
            this.svcheats.UncheckedState.BorderThickness = 0;
            this.svcheats.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.svcheats.UseVisualStyleBackColor = true;
            this.svcheats.CheckedChanged += new System.EventHandler(this.svcheats_CheckedChanged);
            // 
            // Disconnect
            // 
            this.Disconnect.Animated = true;
            this.Disconnect.BorderRadius = 2;
            this.Disconnect.CheckedState.Parent = this.Disconnect;
            this.Disconnect.CustomImages.Parent = this.Disconnect;
            this.Disconnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.Disconnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Disconnect.ForeColor = System.Drawing.Color.White;
            this.Disconnect.HoverState.Parent = this.Disconnect;
            this.Disconnect.Location = new System.Drawing.Point(13, 390);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.ShadowDecoration.Parent = this.Disconnect;
            this.Disconnect.Size = new System.Drawing.Size(195, 22);
            this.Disconnect.TabIndex = 12;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // LaunchPlaylist
            // 
            this.LaunchPlaylist.Animated = true;
            this.LaunchPlaylist.BorderRadius = 2;
            this.LaunchPlaylist.CheckedState.Parent = this.LaunchPlaylist;
            this.LaunchPlaylist.CustomImages.Parent = this.LaunchPlaylist;
            this.LaunchPlaylist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.LaunchPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LaunchPlaylist.ForeColor = System.Drawing.Color.White;
            this.LaunchPlaylist.HoverState.Parent = this.LaunchPlaylist;
            this.LaunchPlaylist.Location = new System.Drawing.Point(13, 129);
            this.LaunchPlaylist.Name = "LaunchPlaylist";
            this.LaunchPlaylist.ShadowDecoration.Parent = this.LaunchPlaylist;
            this.LaunchPlaylist.Size = new System.Drawing.Size(195, 36);
            this.LaunchPlaylist.TabIndex = 11;
            this.LaunchPlaylist.Text = "Launch Playlist";
            this.LaunchPlaylist.Click += new System.EventHandler(this.LaunchPlaylist_Click);
            // 
            // PlaylistCombo
            // 
            this.PlaylistCombo.BackColor = System.Drawing.Color.Transparent;
            this.PlaylistCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.BorderRadius = 2;
            this.PlaylistCombo.BorderThickness = 0;
            this.PlaylistCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PlaylistCombo.DropDownHeight = 200;
            this.PlaylistCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaylistCombo.DropDownWidth = 200;
            this.PlaylistCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedColor = System.Drawing.Color.Empty;
            this.PlaylistCombo.FocusedState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PlaylistCombo.ForeColor = System.Drawing.Color.White;
            this.PlaylistCombo.FormattingEnabled = true;
            this.PlaylistCombo.HoverState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.IntegralHeight = false;
            this.PlaylistCombo.ItemHeight = 25;
            this.PlaylistCombo.ItemsAppearance.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Location = new System.Drawing.Point(13, 92);
            this.PlaylistCombo.MaxDropDownItems = 5;
            this.PlaylistCombo.Name = "PlaylistCombo";
            this.PlaylistCombo.ShadowDecoration.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Size = new System.Drawing.Size(195, 31);
            this.PlaylistCombo.TabIndex = 10;
            // 
            // ChangeMap
            // 
            this.ChangeMap.Animated = true;
            this.ChangeMap.BorderRadius = 2;
            this.ChangeMap.CheckedState.Parent = this.ChangeMap;
            this.ChangeMap.CustomImages.Parent = this.ChangeMap;
            this.ChangeMap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ChangeMap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeMap.ForeColor = System.Drawing.Color.White;
            this.ChangeMap.HoverState.Parent = this.ChangeMap;
            this.ChangeMap.Location = new System.Drawing.Point(13, 50);
            this.ChangeMap.Name = "ChangeMap";
            this.ChangeMap.ShadowDecoration.Parent = this.ChangeMap;
            this.ChangeMap.Size = new System.Drawing.Size(195, 36);
            this.ChangeMap.TabIndex = 9;
            this.ChangeMap.Text = "Change Map";
            this.ChangeMap.Click += new System.EventHandler(this.ChangeMap_Click);
            // 
            // MapCombo
            // 
            this.MapCombo.BackColor = System.Drawing.Color.Transparent;
            this.MapCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.BorderRadius = 2;
            this.MapCombo.BorderThickness = 0;
            this.MapCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MapCombo.DropDownHeight = 200;
            this.MapCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapCombo.DropDownWidth = 200;
            this.MapCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedColor = System.Drawing.Color.Empty;
            this.MapCombo.FocusedState.Parent = this.MapCombo;
            this.MapCombo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MapCombo.ForeColor = System.Drawing.Color.White;
            this.MapCombo.FormattingEnabled = true;
            this.MapCombo.HoverState.Parent = this.MapCombo;
            this.MapCombo.IntegralHeight = false;
            this.MapCombo.ItemHeight = 25;
            this.MapCombo.ItemsAppearance.Parent = this.MapCombo;
            this.MapCombo.Location = new System.Drawing.Point(13, 13);
            this.MapCombo.MaxDropDownItems = 5;
            this.MapCombo.Name = "MapCombo";
            this.MapCombo.ShadowDecoration.Parent = this.MapCombo;
            this.MapCombo.Size = new System.Drawing.Size(195, 31);
            this.MapCombo.TabIndex = 0;
            // 
            // SendCommand
            // 
            this.SendCommand.Animated = true;
            this.SendCommand.BorderRadius = 2;
            this.SendCommand.CheckedState.Parent = this.SendCommand;
            this.SendCommand.CustomImages.Parent = this.SendCommand;
            this.SendCommand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.SendCommand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendCommand.ForeColor = System.Drawing.Color.White;
            this.SendCommand.HoverState.Parent = this.SendCommand;
            this.SendCommand.Location = new System.Drawing.Point(714, 376);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.ShadowDecoration.Parent = this.SendCommand;
            this.SendCommand.Size = new System.Drawing.Size(108, 36);
            this.SendCommand.TabIndex = 8;
            this.SendCommand.Text = "Send";
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.guna2Panel2.BorderRadius = 2;
            this.guna2Panel2.Controls.Add(this.ConsoleBox);
            this.guna2Panel2.Location = new System.Drawing.Point(236, 13);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(586, 357);
            this.guna2Panel2.TabIndex = 9;
            // 
            // checkstatus
            // 
            this.checkstatus.Animated = true;
            this.checkstatus.BorderRadius = 2;
            this.checkstatus.CheckedState.Parent = this.checkstatus;
            this.checkstatus.CustomImages.Parent = this.checkstatus;
            this.checkstatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.checkstatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkstatus.ForeColor = System.Drawing.Color.White;
            this.checkstatus.HoverState.Parent = this.checkstatus;
            this.checkstatus.Location = new System.Drawing.Point(13, 266);
            this.checkstatus.Name = "checkstatus";
            this.checkstatus.ShadowDecoration.Parent = this.checkstatus;
            this.checkstatus.Size = new System.Drawing.Size(195, 25);
            this.checkstatus.TabIndex = 17;
            this.checkstatus.Text = "Check Status";
            this.checkstatus.Click += new System.EventHandler(this.checkstatus_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(13, 250);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(195, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // reloadplaylist
            // 
            this.reloadplaylist.Animated = true;
            this.reloadplaylist.BorderRadius = 2;
            this.reloadplaylist.CheckedState.Parent = this.reloadplaylist;
            this.reloadplaylist.CustomImages.Parent = this.reloadplaylist;
            this.reloadplaylist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.reloadplaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reloadplaylist.ForeColor = System.Drawing.Color.White;
            this.reloadplaylist.HoverState.Parent = this.reloadplaylist;
            this.reloadplaylist.Location = new System.Drawing.Point(13, 297);
            this.reloadplaylist.Name = "reloadplaylist";
            this.reloadplaylist.ShadowDecoration.Parent = this.reloadplaylist;
            this.reloadplaylist.Size = new System.Drawing.Size(195, 25);
            this.reloadplaylist.TabIndex = 19;
            this.reloadplaylist.Text = "Reload Playlist";
            this.reloadplaylist.Click += new System.EventHandler(this.reloadplaylist_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(13, 374);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(195, 10);
            this.guna2Separator2.TabIndex = 20;
            // 
            // R5Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CommandTxt);
            this.DoubleBuffered = true;
            this.Name = "R5Console";
            this.Size = new System.Drawing.Size(837, 430);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox CommandTxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ChangeMap;
        private Guna.UI2.WinForms.Guna2ComboBox MapCombo;
        private Guna.UI2.WinForms.Guna2Button SendCommand;
        private Guna.UI2.WinForms.Guna2Button LaunchPlaylist;
        private Guna.UI2.WinForms.Guna2ComboBox PlaylistCombo;
        public System.Windows.Forms.RichTextBox ConsoleBox;
        private Guna.UI2.WinForms.Guna2Button Disconnect;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button SetPylonVis;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2CheckBox svcheats;
        private Guna.UI2.WinForms.Guna2Button reloadplaylist;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button checkstatus;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}
