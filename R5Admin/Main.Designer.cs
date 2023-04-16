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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TopText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Min = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.r5Console1 = new R5Admin.R5Console();
            this.serverSelect1 = new R5Admin.ServerSelect();
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
            this.TopPanel.Controls.Add(this.TopText);
            this.TopPanel.Controls.Add(this.Min);
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(840, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // TopText
            // 
            this.TopText.BackColor = System.Drawing.Color.Transparent;
            this.TopText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TopText.ForeColor = System.Drawing.Color.White;
            this.TopText.IsSelectionEnabled = false;
            this.TopText.Location = new System.Drawing.Point(5, 4);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(73, 21);
            this.TopText.TabIndex = 3;
            this.TopText.Text = "R5Admin";
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Min.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Min.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.Min.HoverState.Parent = this.Min;
            this.Min.IconColor = System.Drawing.Color.White;
            this.Min.Location = new System.Drawing.Point(782, 0);
            this.Min.Name = "Min";
            this.Min.ShadowDecoration.Parent = this.Min;
            this.Min.Size = new System.Drawing.Size(29, 29);
            this.Min.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(811, 0);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopPanel;
            // 
            // r5Console1
            // 
            this.r5Console1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.r5Console1.Location = new System.Drawing.Point(0, 36);
            this.r5Console1.Name = "r5Console1";
            this.r5Console1.Size = new System.Drawing.Size(837, 430);
            this.r5Console1.TabIndex = 2;
            // 
            // serverSelect1
            // 
            this.serverSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.serverSelect1.Location = new System.Drawing.Point(5, 323);
            this.serverSelect1.Name = "serverSelect1";
            this.serverSelect1.Size = new System.Drawing.Size(840, 430);
            this.serverSelect1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(840, 460);
            this.Controls.Add(this.r5Console1);
            this.Controls.Add(this.serverSelect1);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private R5Console r5Console1;
    }
}