namespace BasicFacebookFeatures.UI.Components
{
    partial class ProfilePageComponent
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
            this.Main = new System.Windows.Forms.FlowLayoutPanel();
            this.profilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.postsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.AutoScroll = true;
            this.Main.AutoSize = true;
            this.Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Controls.Add(this.profilePanel);
            this.Main.Controls.Add(this.postsPanel);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(768, 400);
            this.Main.TabIndex = 0;
            this.Main.WrapContents = false;
            // 
            // profilePanel
            // 
            this.profilePanel.AutoSize = true;
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.profilePanel.MinimumSize = new System.Drawing.Size(256, 100);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(256, 100);
            this.profilePanel.TabIndex = 0;
            this.profilePanel.WrapContents = false;
            // 
            // postsPanel
            // 
            this.postsPanel.AutoSize = true;
            this.postsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.postsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.postsPanel.Location = new System.Drawing.Point(256, 0);
            this.postsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.postsPanel.MaximumSize = new System.Drawing.Size(512, 0);
            this.postsPanel.MinimumSize = new System.Drawing.Size(512, 100);
            this.postsPanel.Name = "postsPanel";
            this.postsPanel.Size = new System.Drawing.Size(512, 100);
            this.postsPanel.TabIndex = 1;
            // 
            // ProfilePageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfilePageComponent";
            this.Size = new System.Drawing.Size(768, 400);
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main;
        private System.Windows.Forms.FlowLayoutPanel profilePanel;
        private System.Windows.Forms.FlowLayoutPanel postsPanel;
    }
}
