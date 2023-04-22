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
            this.SendCommand = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox.Font = new System.Drawing.Font("Arial", 12F);
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Location = new System.Drawing.Point(6, 6);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(961, 464);
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
            this.CommandTxt.Location = new System.Drawing.Point(13, 495);
            this.CommandTxt.Name = "CommandTxt";
            this.CommandTxt.PasswordChar = '\0';
            this.CommandTxt.PlaceholderText = "Enter Command";
            this.CommandTxt.SelectedText = "";
            this.CommandTxt.ShadowDecoration.Parent = this.CommandTxt;
            this.CommandTxt.Size = new System.Drawing.Size(859, 36);
            this.CommandTxt.TabIndex = 6;
            this.CommandTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandTxt_KeyDown);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 2;
            this.guna2Elipse1.TargetControl = this.ConsoleBox;
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
            this.SendCommand.Location = new System.Drawing.Point(878, 495);
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
            this.guna2Panel2.Location = new System.Drawing.Point(13, 13);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(973, 476);
            this.guna2Panel2.TabIndex = 9;
            // 
            // R5Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.CommandTxt);
            this.DoubleBuffered = true;
            this.Name = "R5Console";
            this.Size = new System.Drawing.Size(1000, 546);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox CommandTxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button SendCommand;
        public System.Windows.Forms.RichTextBox ConsoleBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
