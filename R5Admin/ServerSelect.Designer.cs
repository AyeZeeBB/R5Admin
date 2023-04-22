namespace R5Admin
{
    partial class ServerSelect
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
            this.ServersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AddServerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ServerCancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServerPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerPortTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerIPTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerAddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServerNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddServerError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddNewServer = new Guna.UI2.WinForms.Guna2Button();
            this.ServersPanel.SuspendLayout();
            this.AddServerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServersPanel
            // 
            this.ServersPanel.AutoScroll = true;
            this.ServersPanel.Controls.Add(this.AddNewServer);
            this.ServersPanel.Location = new System.Drawing.Point(81, 206);
            this.ServersPanel.Name = "ServersPanel";
            this.ServersPanel.ShadowDecoration.Parent = this.ServersPanel;
            this.ServersPanel.Size = new System.Drawing.Size(997, 546);
            this.ServersPanel.TabIndex = 7;
            // 
            // AddServerPanel
            // 
            this.AddServerPanel.Controls.Add(this.AddServerError);
            this.AddServerPanel.Controls.Add(this.guna2HtmlLabel1);
            this.AddServerPanel.Controls.Add(this.ServerCancelBtn);
            this.AddServerPanel.Controls.Add(this.ServerPasswordTxt);
            this.AddServerPanel.Controls.Add(this.ServerPortTxt);
            this.AddServerPanel.Controls.Add(this.ServerIPTxt);
            this.AddServerPanel.Controls.Add(this.ServerAddBtn);
            this.AddServerPanel.Controls.Add(this.ServerNameTxt);
            this.AddServerPanel.Location = new System.Drawing.Point(529, 84);
            this.AddServerPanel.Name = "AddServerPanel";
            this.AddServerPanel.ShadowDecoration.Parent = this.AddServerPanel;
            this.AddServerPanel.Size = new System.Drawing.Size(997, 546);
            this.AddServerPanel.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 120);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(997, 26);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Add Server";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerCancelBtn
            // 
            this.ServerCancelBtn.Animated = true;
            this.ServerCancelBtn.BorderRadius = 2;
            this.ServerCancelBtn.CheckedState.Parent = this.ServerCancelBtn;
            this.ServerCancelBtn.CustomImages.Parent = this.ServerCancelBtn;
            this.ServerCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerCancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerCancelBtn.ForeColor = System.Drawing.Color.White;
            this.ServerCancelBtn.HoverState.Parent = this.ServerCancelBtn;
            this.ServerCancelBtn.Location = new System.Drawing.Point(566, 294);
            this.ServerCancelBtn.Name = "ServerCancelBtn";
            this.ServerCancelBtn.ShadowDecoration.Parent = this.ServerCancelBtn;
            this.ServerCancelBtn.Size = new System.Drawing.Size(129, 45);
            this.ServerCancelBtn.TabIndex = 8;
            this.ServerCancelBtn.Text = "Cancel";
            this.ServerCancelBtn.Click += new System.EventHandler(this.ServerCancelBtn_Click);
            // 
            // ServerPasswordTxt
            // 
            this.ServerPasswordTxt.Animated = true;
            this.ServerPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerPasswordTxt.BorderRadius = 2;
            this.ServerPasswordTxt.BorderThickness = 0;
            this.ServerPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerPasswordTxt.DefaultText = "";
            this.ServerPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPasswordTxt.DisabledState.Parent = this.ServerPasswordTxt;
            this.ServerPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPasswordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerPasswordTxt.FocusedState.Parent = this.ServerPasswordTxt;
            this.ServerPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerPasswordTxt.HoverState.Parent = this.ServerPasswordTxt;
            this.ServerPasswordTxt.Location = new System.Drawing.Point(297, 252);
            this.ServerPasswordTxt.Name = "ServerPasswordTxt";
            this.ServerPasswordTxt.PasswordChar = '●';
            this.ServerPasswordTxt.PlaceholderText = "Password (optional)";
            this.ServerPasswordTxt.SelectedText = "";
            this.ServerPasswordTxt.ShadowDecoration.Parent = this.ServerPasswordTxt;
            this.ServerPasswordTxt.Size = new System.Drawing.Size(398, 36);
            this.ServerPasswordTxt.TabIndex = 7;
            // 
            // ServerPortTxt
            // 
            this.ServerPortTxt.Animated = true;
            this.ServerPortTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerPortTxt.BorderRadius = 2;
            this.ServerPortTxt.BorderThickness = 0;
            this.ServerPortTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerPortTxt.DefaultText = "";
            this.ServerPortTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerPortTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerPortTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTxt.DisabledState.Parent = this.ServerPortTxt;
            this.ServerPortTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerPortTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerPortTxt.FocusedState.Parent = this.ServerPortTxt;
            this.ServerPortTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerPortTxt.HoverState.Parent = this.ServerPortTxt;
            this.ServerPortTxt.Location = new System.Drawing.Point(566, 210);
            this.ServerPortTxt.Name = "ServerPortTxt";
            this.ServerPortTxt.PasswordChar = '\0';
            this.ServerPortTxt.PlaceholderText = "Port (required)";
            this.ServerPortTxt.SelectedText = "";
            this.ServerPortTxt.ShadowDecoration.Parent = this.ServerPortTxt;
            this.ServerPortTxt.Size = new System.Drawing.Size(129, 36);
            this.ServerPortTxt.TabIndex = 6;
            this.ServerPortTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerPortTxt_KeyPress);
            // 
            // ServerIPTxt
            // 
            this.ServerIPTxt.Animated = true;
            this.ServerIPTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerIPTxt.BorderRadius = 2;
            this.ServerIPTxt.BorderThickness = 0;
            this.ServerIPTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerIPTxt.DefaultText = "";
            this.ServerIPTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerIPTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerIPTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerIPTxt.DisabledState.Parent = this.ServerIPTxt;
            this.ServerIPTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerIPTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerIPTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerIPTxt.FocusedState.Parent = this.ServerIPTxt;
            this.ServerIPTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerIPTxt.HoverState.Parent = this.ServerIPTxt;
            this.ServerIPTxt.Location = new System.Drawing.Point(297, 210);
            this.ServerIPTxt.Name = "ServerIPTxt";
            this.ServerIPTxt.PasswordChar = '\0';
            this.ServerIPTxt.PlaceholderText = "IP (required)";
            this.ServerIPTxt.SelectedText = "";
            this.ServerIPTxt.ShadowDecoration.Parent = this.ServerIPTxt;
            this.ServerIPTxt.Size = new System.Drawing.Size(263, 36);
            this.ServerIPTxt.TabIndex = 5;
            this.ServerIPTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerIPTxt_KeyPress);
            // 
            // ServerAddBtn
            // 
            this.ServerAddBtn.Animated = true;
            this.ServerAddBtn.BorderRadius = 2;
            this.ServerAddBtn.CheckedState.Parent = this.ServerAddBtn;
            this.ServerAddBtn.CustomImages.Parent = this.ServerAddBtn;
            this.ServerAddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerAddBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerAddBtn.ForeColor = System.Drawing.Color.White;
            this.ServerAddBtn.HoverState.Parent = this.ServerAddBtn;
            this.ServerAddBtn.Location = new System.Drawing.Point(297, 294);
            this.ServerAddBtn.Name = "ServerAddBtn";
            this.ServerAddBtn.ShadowDecoration.Parent = this.ServerAddBtn;
            this.ServerAddBtn.Size = new System.Drawing.Size(263, 45);
            this.ServerAddBtn.TabIndex = 4;
            this.ServerAddBtn.Text = "Add";
            this.ServerAddBtn.Click += new System.EventHandler(this.ServerAddBtn_Click);
            // 
            // ServerNameTxt
            // 
            this.ServerNameTxt.Animated = true;
            this.ServerNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerNameTxt.BorderRadius = 2;
            this.ServerNameTxt.BorderThickness = 0;
            this.ServerNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerNameTxt.DefaultText = "";
            this.ServerNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerNameTxt.DisabledState.Parent = this.ServerNameTxt;
            this.ServerNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerNameTxt.FocusedState.Parent = this.ServerNameTxt;
            this.ServerNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerNameTxt.HoverState.Parent = this.ServerNameTxt;
            this.ServerNameTxt.Location = new System.Drawing.Point(297, 168);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.PasswordChar = '\0';
            this.ServerNameTxt.PlaceholderText = "Server Name (required)";
            this.ServerNameTxt.SelectedText = "";
            this.ServerNameTxt.ShadowDecoration.Parent = this.ServerNameTxt;
            this.ServerNameTxt.Size = new System.Drawing.Size(398, 36);
            this.ServerNameTxt.TabIndex = 0;
            // 
            // AddServerError
            // 
            this.AddServerError.AutoSize = false;
            this.AddServerError.BackColor = System.Drawing.Color.Transparent;
            this.AddServerError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AddServerError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.AddServerError.Location = new System.Drawing.Point(-3, 513);
            this.AddServerError.Name = "AddServerError";
            this.AddServerError.Size = new System.Drawing.Size(1000, 33);
            this.AddServerError.TabIndex = 10;
            this.AddServerError.Text = "Error Text";
            this.AddServerError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddServerError.Visible = false;
            // 
            // AddNewServer
            // 
            this.AddNewServer.Animated = true;
            this.AddNewServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.AddNewServer.BorderRadius = 2;
            this.AddNewServer.BorderThickness = 2;
            this.AddNewServer.CheckedState.Parent = this.AddNewServer;
            this.AddNewServer.CustomImages.Parent = this.AddNewServer;
            this.AddNewServer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.AddNewServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewServer.ForeColor = System.Drawing.Color.White;
            this.AddNewServer.HoverState.Parent = this.AddNewServer;
            this.AddNewServer.Image = global::R5Admin.Properties.Resources.icons8_add_64;
            this.AddNewServer.ImageOffset = new System.Drawing.Point(0, -15);
            this.AddNewServer.ImageSize = new System.Drawing.Size(40, 40);
            this.AddNewServer.Location = new System.Drawing.Point(33, 33);
            this.AddNewServer.Name = "AddNewServer";
            this.AddNewServer.ShadowDecoration.Parent = this.AddNewServer;
            this.AddNewServer.Size = new System.Drawing.Size(150, 150);
            this.AddNewServer.TabIndex = 0;
            this.AddNewServer.Text = "Add Server";
            this.AddNewServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddNewServer.TextOffset = new System.Drawing.Point(-30, 30);
            // 
            // ServerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.AddServerPanel);
            this.Controls.Add(this.ServersPanel);
            this.DoubleBuffered = true;
            this.Name = "ServerSelect";
            this.Size = new System.Drawing.Size(1000, 546);
            this.Load += new System.EventHandler(this.ServerSelect_Load);
            this.ServersPanel.ResumeLayout(false);
            this.AddServerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddNewServer;
        private Guna.UI2.WinForms.Guna2Panel ServersPanel;
        private Guna.UI2.WinForms.Guna2Panel AddServerPanel;
        private Guna.UI2.WinForms.Guna2Button ServerAddBtn;
        private Guna.UI2.WinForms.Guna2TextBox ServerNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox ServerPasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox ServerPortTxt;
        private Guna.UI2.WinForms.Guna2TextBox ServerIPTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ServerCancelBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel AddServerError;
    }
}
