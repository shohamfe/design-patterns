using System;

namespace BasicFacebookFeatures
{
    partial class FacebookMainForm
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
            this.Main = new System.Windows.Forms.FlowLayoutPanel();
            this.m_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.m_ProfileName = new System.Windows.Forms.Label();
            this.m_FeedButton = new System.Windows.Forms.Button();
            this.m_ProfileButton = new System.Windows.Forms.Button();
            this.m_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(200, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(4);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(600, 450);
            this.Main.TabIndex = 70;
            // 
            // m_Menu
            // 
            this.m_Menu.Controls.Add(this.FacebookLogo);
            this.m_Menu.Controls.Add(this.flowLayoutPanel1);
            this.m_Menu.Controls.Add(this.m_FeedButton);
            this.m_Menu.Controls.Add(this.m_ProfileButton);
            this.m_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Margin = new System.Windows.Forms.Padding(8);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(200, 450);
            this.m_Menu.TabIndex = 72;
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_round_color;
            this.FacebookLogo.Location = new System.Drawing.Point(4, 4);
            this.FacebookLogo.Margin = new System.Windows.Forms.Padding(4);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(40, 40);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FacebookLogo.TabIndex = 68;
            this.FacebookLogo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxProfile);
            this.flowLayoutPanel1.Controls.Add(this.m_ProfileName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 44);
            this.flowLayoutPanel1.TabIndex = 70;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 56;
            this.pictureBoxProfile.TabStop = false;
            // 
            // m_ProfileName
            // 
            this.m_ProfileName.AutoSize = true;
            this.m_ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ProfileName.Location = new System.Drawing.Point(48, 13);
            this.m_ProfileName.Margin = new System.Windows.Forms.Padding(4, 13, 4, 4);
            this.m_ProfileName.Name = "m_ProfileName";
            this.m_ProfileName.Size = new System.Drawing.Size(101, 17);
            this.m_ProfileName.TabIndex = 57;
            this.m_ProfileName.Text = "Profile Name";
            // 
            // m_FeedButton
            // 
            this.m_FeedButton.Location = new System.Drawing.Point(4, 104);
            this.m_FeedButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_FeedButton.Name = "m_FeedButton";
            this.m_FeedButton.Size = new System.Drawing.Size(192, 23);
            this.m_FeedButton.TabIndex = 57;
            this.m_FeedButton.Text = "Feed";
            this.m_FeedButton.UseVisualStyleBackColor = true;
            // 
            // m_ProfileButton
            // 
            this.m_ProfileButton.Location = new System.Drawing.Point(4, 135);
            this.m_ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_ProfileButton.Name = "m_ProfileButton";
            this.m_ProfileButton.Size = new System.Drawing.Size(192, 23);
            this.m_ProfileButton.TabIndex = 69;
            this.m_ProfileButton.Text = "Profile";
            this.m_ProfileButton.UseVisualStyleBackColor = true;
            this.m_ProfileButton.Click += new System.EventHandler(this.m_ProfileButton_Click);
            // 
            // FacebookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.m_Menu);
            this.Name = "FacebookMainForm";
            this.Load += new System.EventHandler(this.FacebookMainForm_Load);
            this.m_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Main;
        private System.Windows.Forms.FlowLayoutPanel m_Menu;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button m_FeedButton;
        private System.Windows.Forms.Button m_ProfileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label m_ProfileName;
    }
}