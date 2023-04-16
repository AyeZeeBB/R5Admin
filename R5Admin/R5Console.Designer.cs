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
            this.LaunchPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.PlaylistCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ChangeMap = new Guna.UI2.WinForms.Guna2Button();
            this.MapCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SendCommand = new Guna.UI2.WinForms.Guna2Button();
            this.Disconnect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(236, 13);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(586, 357);
            this.ConsoleBox.TabIndex = 0;
            this.ConsoleBox.Text = "";
            this.ConsoleBox.TextChanged += new System.EventHandler(this.ConsoleBox_TextChanged);
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
            this.PlaylistCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaylistCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedColor = System.Drawing.Color.Empty;
            this.PlaylistCombo.FocusedState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PlaylistCombo.ForeColor = System.Drawing.Color.White;
            this.PlaylistCombo.FormattingEnabled = true;
            this.PlaylistCombo.HoverState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.ItemHeight = 25;
            this.PlaylistCombo.ItemsAppearance.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Location = new System.Drawing.Point(13, 92);
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
            this.MapCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedColor = System.Drawing.Color.Empty;
            this.MapCombo.FocusedState.Parent = this.MapCombo;
            this.MapCombo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MapCombo.ForeColor = System.Drawing.Color.White;
            this.MapCombo.FormattingEnabled = true;
            this.MapCombo.HoverState.Parent = this.MapCombo;
            this.MapCombo.ItemHeight = 25;
            this.MapCombo.ItemsAppearance.Parent = this.MapCombo;
            this.MapCombo.Location = new System.Drawing.Point(13, 13);
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
            this.Disconnect.Location = new System.Drawing.Point(13, 376);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.ShadowDecoration.Parent = this.Disconnect;
            this.Disconnect.Size = new System.Drawing.Size(195, 36);
            this.Disconnect.TabIndex = 12;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // R5Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CommandTxt);
            this.Controls.Add(this.ConsoleBox);
            this.DoubleBuffered = true;
            this.Name = "R5Console";
            this.Size = new System.Drawing.Size(837, 430);
            this.guna2Panel1.ResumeLayout(false);
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
    }
}
