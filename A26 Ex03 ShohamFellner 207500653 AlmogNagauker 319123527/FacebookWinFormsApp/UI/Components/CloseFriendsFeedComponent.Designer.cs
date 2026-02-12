namespace BasicFacebookFeatures.UI.Components
{
    partial class CloseFriendsFeedComponent
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
            this.postsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Main = new System.Windows.Forms.FlowLayoutPanel();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // postsPanel
            // 
            this.postsPanel.AutoSize = true;
            this.postsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.postsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.postsPanel.Location = new System.Drawing.Point(0, 0);
            this.postsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.postsPanel.MaximumSize = new System.Drawing.Size(683, 0);
            this.postsPanel.MinimumSize = new System.Drawing.Size(683, 123);
            this.postsPanel.Name = "postsPanel";
            this.postsPanel.Size = new System.Drawing.Size(683, 123);
            this.postsPanel.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.AutoScroll = true;
            this.Main.AutoSize = true;
            this.Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Controls.Add(this.postsPanel);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(890, 150);
            this.Main.TabIndex = 2;
            this.Main.WrapContents = false;
            // 
            // m_CloseFriendsFeedComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main);
            this.Name = "CloseFriendsFeedComponent";
            this.Size = new System.Drawing.Size(890, 150);
            this.Load += new System.EventHandler(this.CloseFriendFeed_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel postsPanel;
        private System.Windows.Forms.FlowLayoutPanel Main;
    }
}
