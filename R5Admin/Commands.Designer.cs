namespace R5Admin
{
    partial class Commands
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
            this.SetPylonVis = new Guna.UI2.WinForms.Guna2Button();
            this.PylonVisCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LaunchPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.PlaylistCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ChangeMap = new Guna.UI2.WinForms.Guna2Button();
            this.MapCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SetServerName = new Guna.UI2.WinForms.Guna2Button();
            this.SetServerDesc = new Guna.UI2.WinForms.Guna2Button();
            this.ServerNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerDescTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.NetKeyTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SetCustomNetKey = new Guna.UI2.WinForms.Guna2Button();
            this.GenerateNetKey = new Guna.UI2.WinForms.Guna2Button();
            this.CustomTogglesBox = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.SetPylonVis.Location = new System.Drawing.Point(665, 54);
            this.SetPylonVis.Name = "SetPylonVis";
            this.SetPylonVis.ShadowDecoration.Parent = this.SetPylonVis;
            this.SetPylonVis.Size = new System.Drawing.Size(319, 36);
            this.SetPylonVis.TabIndex = 16;
            this.SetPylonVis.Text = "Set Pylon Visibility";
            this.SetPylonVis.Click += new System.EventHandler(this.SetPylonVis_Click);
            // 
            // PylonVisCombo
            // 
            this.PylonVisCombo.Animated = true;
            this.PylonVisCombo.BackColor = System.Drawing.Color.Transparent;
            this.PylonVisCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.BorderRadius = 2;
            this.PylonVisCombo.BorderThickness = 0;
            this.PylonVisCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PylonVisCombo.DropDownHeight = 200;
            this.PylonVisCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PylonVisCombo.DropDownWidth = 200;
            this.PylonVisCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.FocusedState.Parent = this.PylonVisCombo;
            this.PylonVisCombo.Font = new System.Drawing.Font("Arial", 10F);
            this.PylonVisCombo.ForeColor = System.Drawing.Color.White;
            this.PylonVisCombo.FormattingEnabled = true;
            this.PylonVisCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PylonVisCombo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PylonVisCombo.HoverState.Parent = this.PylonVisCombo;
            this.PylonVisCombo.IntegralHeight = false;
            this.PylonVisCombo.ItemHeight = 25;
            this.PylonVisCombo.Items.AddRange(new object[] {
            "Offline",
            "Hidden",
            "Public"});
            this.PylonVisCombo.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PylonVisCombo.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.PylonVisCombo.ItemsAppearance.Parent = this.PylonVisCombo;
            this.PylonVisCombo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PylonVisCombo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.PylonVisCombo.Location = new System.Drawing.Point(665, 17);
            this.PylonVisCombo.MaxDropDownItems = 5;
            this.PylonVisCombo.Name = "PylonVisCombo";
            this.PylonVisCombo.ShadowDecoration.Parent = this.PylonVisCombo;
            this.PylonVisCombo.Size = new System.Drawing.Size(319, 31);
            this.PylonVisCombo.StartIndex = 0;
            this.PylonVisCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PylonVisCombo.TabIndex = 15;
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
            this.LaunchPlaylist.Location = new System.Drawing.Point(340, 54);
            this.LaunchPlaylist.Name = "LaunchPlaylist";
            this.LaunchPlaylist.ShadowDecoration.Parent = this.LaunchPlaylist;
            this.LaunchPlaylist.Size = new System.Drawing.Size(319, 36);
            this.LaunchPlaylist.TabIndex = 11;
            this.LaunchPlaylist.Text = "Launch Playlist";
            this.LaunchPlaylist.Click += new System.EventHandler(this.LaunchPlaylist_Click);
            // 
            // PlaylistCombo
            // 
            this.PlaylistCombo.Animated = true;
            this.PlaylistCombo.BackColor = System.Drawing.Color.Transparent;
            this.PlaylistCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.BorderRadius = 2;
            this.PlaylistCombo.BorderThickness = 0;
            this.PlaylistCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PlaylistCombo.DropDownHeight = 200;
            this.PlaylistCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaylistCombo.DropDownWidth = 200;
            this.PlaylistCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.FocusedState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Font = new System.Drawing.Font("Arial", 10F);
            this.PlaylistCombo.ForeColor = System.Drawing.Color.White;
            this.PlaylistCombo.FormattingEnabled = true;
            this.PlaylistCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PlaylistCombo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PlaylistCombo.HoverState.Parent = this.PlaylistCombo;
            this.PlaylistCombo.IntegralHeight = false;
            this.PlaylistCombo.ItemHeight = 25;
            this.PlaylistCombo.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.PlaylistCombo.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.PlaylistCombo.ItemsAppearance.Parent = this.PlaylistCombo;
            this.PlaylistCombo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.PlaylistCombo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.PlaylistCombo.Location = new System.Drawing.Point(340, 17);
            this.PlaylistCombo.MaxDropDownItems = 5;
            this.PlaylistCombo.Name = "PlaylistCombo";
            this.PlaylistCombo.ShadowDecoration.Parent = this.PlaylistCombo;
            this.PlaylistCombo.Size = new System.Drawing.Size(319, 31);
            this.PlaylistCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
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
            this.ChangeMap.Location = new System.Drawing.Point(15, 54);
            this.ChangeMap.Name = "ChangeMap";
            this.ChangeMap.ShadowDecoration.Parent = this.ChangeMap;
            this.ChangeMap.Size = new System.Drawing.Size(319, 36);
            this.ChangeMap.TabIndex = 9;
            this.ChangeMap.Text = "Change Map";
            this.ChangeMap.Click += new System.EventHandler(this.ChangeMap_Click);
            // 
            // MapCombo
            // 
            this.MapCombo.Animated = true;
            this.MapCombo.BackColor = System.Drawing.Color.Transparent;
            this.MapCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.BorderRadius = 2;
            this.MapCombo.BorderThickness = 0;
            this.MapCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MapCombo.DropDownHeight = 200;
            this.MapCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapCombo.DropDownWidth = 200;
            this.MapCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.FocusedState.Parent = this.MapCombo;
            this.MapCombo.Font = new System.Drawing.Font("Arial", 10F);
            this.MapCombo.ForeColor = System.Drawing.Color.White;
            this.MapCombo.FormattingEnabled = true;
            this.MapCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.MapCombo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.MapCombo.HoverState.Parent = this.MapCombo;
            this.MapCombo.IntegralHeight = false;
            this.MapCombo.ItemHeight = 25;
            this.MapCombo.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.MapCombo.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.MapCombo.ItemsAppearance.Parent = this.MapCombo;
            this.MapCombo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.MapCombo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.MapCombo.Location = new System.Drawing.Point(15, 17);
            this.MapCombo.MaxDropDownItems = 5;
            this.MapCombo.Name = "MapCombo";
            this.MapCombo.ShadowDecoration.Parent = this.MapCombo;
            this.MapCombo.Size = new System.Drawing.Size(319, 31);
            this.MapCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MapCombo.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(15, 293);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(969, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // SetServerName
            // 
            this.SetServerName.Animated = true;
            this.SetServerName.BorderRadius = 2;
            this.SetServerName.CheckedState.Parent = this.SetServerName;
            this.SetServerName.CustomImages.Parent = this.SetServerName;
            this.SetServerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.SetServerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetServerName.ForeColor = System.Drawing.Color.White;
            this.SetServerName.HoverState.Parent = this.SetServerName;
            this.SetServerName.Location = new System.Drawing.Point(747, 147);
            this.SetServerName.Name = "SetServerName";
            this.SetServerName.ShadowDecoration.Parent = this.SetServerName;
            this.SetServerName.Size = new System.Drawing.Size(237, 36);
            this.SetServerName.TabIndex = 24;
            this.SetServerName.Text = "Set";
            this.SetServerName.Click += new System.EventHandler(this.SetServerName_Click);
            // 
            // SetServerDesc
            // 
            this.SetServerDesc.Animated = true;
            this.SetServerDesc.BorderRadius = 2;
            this.SetServerDesc.CheckedState.Parent = this.SetServerDesc;
            this.SetServerDesc.CustomImages.Parent = this.SetServerDesc;
            this.SetServerDesc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.SetServerDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetServerDesc.ForeColor = System.Drawing.Color.White;
            this.SetServerDesc.HoverState.Parent = this.SetServerDesc;
            this.SetServerDesc.Location = new System.Drawing.Point(747, 189);
            this.SetServerDesc.Name = "SetServerDesc";
            this.SetServerDesc.ShadowDecoration.Parent = this.SetServerDesc;
            this.SetServerDesc.Size = new System.Drawing.Size(237, 36);
            this.SetServerDesc.TabIndex = 25;
            this.SetServerDesc.Text = "Set";
            this.SetServerDesc.Click += new System.EventHandler(this.SetServerDesc_Click);
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
            this.ServerNameTxt.Location = new System.Drawing.Point(15, 147);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.PasswordChar = '●';
            this.ServerNameTxt.PlaceholderText = "Server Name";
            this.ServerNameTxt.SelectedText = "";
            this.ServerNameTxt.ShadowDecoration.Parent = this.ServerNameTxt;
            this.ServerNameTxt.Size = new System.Drawing.Size(726, 36);
            this.ServerNameTxt.TabIndex = 26;
            // 
            // ServerDescTxt
            // 
            this.ServerDescTxt.Animated = true;
            this.ServerDescTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerDescTxt.BorderRadius = 2;
            this.ServerDescTxt.BorderThickness = 0;
            this.ServerDescTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerDescTxt.DefaultText = "";
            this.ServerDescTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerDescTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerDescTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerDescTxt.DisabledState.Parent = this.ServerDescTxt;
            this.ServerDescTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerDescTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ServerDescTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerDescTxt.FocusedState.Parent = this.ServerDescTxt;
            this.ServerDescTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.ServerDescTxt.HoverState.Parent = this.ServerDescTxt;
            this.ServerDescTxt.Location = new System.Drawing.Point(15, 189);
            this.ServerDescTxt.Name = "ServerDescTxt";
            this.ServerDescTxt.PasswordChar = '●';
            this.ServerDescTxt.PlaceholderText = "Server Description";
            this.ServerDescTxt.SelectedText = "";
            this.ServerDescTxt.ShadowDecoration.Parent = this.ServerDescTxt;
            this.ServerDescTxt.Size = new System.Drawing.Size(726, 36);
            this.ServerDescTxt.TabIndex = 27;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(15, 114);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(969, 10);
            this.guna2Separator2.TabIndex = 28;
            // 
            // NetKeyTxt
            // 
            this.NetKeyTxt.Animated = true;
            this.NetKeyTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.NetKeyTxt.BorderRadius = 2;
            this.NetKeyTxt.BorderThickness = 0;
            this.NetKeyTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NetKeyTxt.DefaultText = "";
            this.NetKeyTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NetKeyTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NetKeyTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NetKeyTxt.DisabledState.Parent = this.NetKeyTxt;
            this.NetKeyTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NetKeyTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.NetKeyTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.NetKeyTxt.FocusedState.Parent = this.NetKeyTxt;
            this.NetKeyTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.NetKeyTxt.HoverState.Parent = this.NetKeyTxt;
            this.NetKeyTxt.Location = new System.Drawing.Point(15, 231);
            this.NetKeyTxt.Name = "NetKeyTxt";
            this.NetKeyTxt.PasswordChar = '\0';
            this.NetKeyTxt.PlaceholderText = "NetKey";
            this.NetKeyTxt.SelectedText = "";
            this.NetKeyTxt.ShadowDecoration.Parent = this.NetKeyTxt;
            this.NetKeyTxt.Size = new System.Drawing.Size(482, 36);
            this.NetKeyTxt.TabIndex = 30;
            // 
            // SetCustomNetKey
            // 
            this.SetCustomNetKey.Animated = true;
            this.SetCustomNetKey.BorderRadius = 2;
            this.SetCustomNetKey.CheckedState.Parent = this.SetCustomNetKey;
            this.SetCustomNetKey.CustomImages.Parent = this.SetCustomNetKey;
            this.SetCustomNetKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.SetCustomNetKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetCustomNetKey.ForeColor = System.Drawing.Color.White;
            this.SetCustomNetKey.HoverState.Parent = this.SetCustomNetKey;
            this.SetCustomNetKey.Location = new System.Drawing.Point(503, 231);
            this.SetCustomNetKey.Name = "SetCustomNetKey";
            this.SetCustomNetKey.ShadowDecoration.Parent = this.SetCustomNetKey;
            this.SetCustomNetKey.Size = new System.Drawing.Size(238, 36);
            this.SetCustomNetKey.TabIndex = 29;
            this.SetCustomNetKey.Text = "Set";
            this.SetCustomNetKey.Click += new System.EventHandler(this.SetCustomNetKey_Click);
            // 
            // GenerateNetKey
            // 
            this.GenerateNetKey.Animated = true;
            this.GenerateNetKey.BorderRadius = 2;
            this.GenerateNetKey.CheckedState.Parent = this.GenerateNetKey;
            this.GenerateNetKey.CustomImages.Parent = this.GenerateNetKey;
            this.GenerateNetKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.GenerateNetKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateNetKey.ForeColor = System.Drawing.Color.White;
            this.GenerateNetKey.HoverState.Parent = this.GenerateNetKey;
            this.GenerateNetKey.Location = new System.Drawing.Point(747, 231);
            this.GenerateNetKey.Name = "GenerateNetKey";
            this.GenerateNetKey.ShadowDecoration.Parent = this.GenerateNetKey;
            this.GenerateNetKey.Size = new System.Drawing.Size(237, 36);
            this.GenerateNetKey.TabIndex = 31;
            this.GenerateNetKey.Text = "Generate New & Set";
            this.GenerateNetKey.Click += new System.EventHandler(this.GenerateNetKey_Click);
            // 
            // CustomTogglesBox
            // 
            this.CustomTogglesBox.AutoScroll = true;
            this.CustomTogglesBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.CustomTogglesBox.BorderRadius = 4;
            this.CustomTogglesBox.Location = new System.Drawing.Point(3, 4);
            this.CustomTogglesBox.Name = "CustomTogglesBox";
            this.CustomTogglesBox.ShadowDecoration.Parent = this.CustomTogglesBox;
            this.CustomTogglesBox.Size = new System.Drawing.Size(476, 168);
            this.CustomTogglesBox.TabIndex = 33;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.guna2Panel5.BorderRadius = 4;
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel5.Location = new System.Drawing.Point(15, 326);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(482, 30);
            this.guna2Panel5.TabIndex = 34;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.IsSelectionEnabled = false;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(129, 21);
            this.guna2HtmlLabel4.TabIndex = 21;
            this.guna2HtmlLabel4.Text = "Custom Toggles";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.guna2Panel4.BorderRadius = 4;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.CustomTogglesBox);
            this.guna2Panel4.Location = new System.Drawing.Point(15, 353);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(482, 175);
            this.guna2Panel4.TabIndex = 34;
            // 
            // Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.GenerateNetKey);
            this.Controls.Add(this.NetKeyTxt);
            this.Controls.Add(this.SetCustomNetKey);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.ServerDescTxt);
            this.Controls.Add(this.ServerNameTxt);
            this.Controls.Add(this.SetServerDesc);
            this.Controls.Add(this.SetServerName);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.MapCombo);
            this.Controls.Add(this.ChangeMap);
            this.Controls.Add(this.SetPylonVis);
            this.Controls.Add(this.PlaylistCombo);
            this.Controls.Add(this.PylonVisCombo);
            this.Controls.Add(this.LaunchPlaylist);
            this.Controls.Add(this.guna2Panel4);
            this.DoubleBuffered = true;
            this.Name = "Commands";
            this.Size = new System.Drawing.Size(1000, 546);
            this.Load += new System.EventHandler(this.Commands_Load);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SetPylonVis;
        private Guna.UI2.WinForms.Guna2ComboBox PylonVisCombo;
        private Guna.UI2.WinForms.Guna2Button LaunchPlaylist;
        private Guna.UI2.WinForms.Guna2ComboBox PlaylistCombo;
        private Guna.UI2.WinForms.Guna2Button ChangeMap;
        private Guna.UI2.WinForms.Guna2ComboBox MapCombo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button SetServerName;
        private Guna.UI2.WinForms.Guna2Button SetServerDesc;
        private Guna.UI2.WinForms.Guna2TextBox ServerNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox ServerDescTxt;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox NetKeyTxt;
        private Guna.UI2.WinForms.Guna2Button SetCustomNetKey;
        private Guna.UI2.WinForms.Guna2Button GenerateNetKey;
        private Guna.UI2.WinForms.Guna2Panel CustomTogglesBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    }
}
