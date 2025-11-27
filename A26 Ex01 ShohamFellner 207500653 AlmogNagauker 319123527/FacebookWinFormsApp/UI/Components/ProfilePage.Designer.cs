namespace BasicFacebookFeatures.UI.Components
{
    partial class ProfilePage
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
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.AutoScroll = true;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(500, 400);
            this.Main.TabIndex = 0;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main;
    }
}
