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
            this.m_BioComponent = new BasicFacebookFeatures.UI.Components.BioComponent();
            this.m_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.m_FeedButton = new System.Windows.Forms.Button();
            this.m_ProfileButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.postComponent1 = new BasicFacebookFeatures.UI.Components.PostComponent();
            this.Main.SuspendLayout();
            this.m_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.m_BioComponent);
            this.Main.Controls.Add(this.postComponent1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(88, 0, 0, 0);
            this.Main.Size = new System.Drawing.Size(800, 450);
            this.Main.TabIndex = 70;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // m_BioComponent
            // 
            this.m_BioComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_BioComponent.Location = new System.Drawing.Point(91, 3);
            this.m_BioComponent.Name = "m_BioComponent";
            this.m_BioComponent.Size = new System.Drawing.Size(269, 253);
            this.m_BioComponent.TabIndex = 69;
            this.m_BioComponent.Visible = false;
            // 
            // m_Menu
            // 
            this.m_Menu.Controls.Add(this.FacebookLogo);
            this.m_Menu.Controls.Add(this.pictureBoxProfile);
            this.m_Menu.Controls.Add(this.m_FeedButton);
            this.m_Menu.Controls.Add(this.m_ProfileButton);
            this.m_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(80, 450);
            this.m_Menu.TabIndex = 72;
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_round_color;
            this.FacebookLogo.Location = new System.Drawing.Point(3, 3);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(79, 78);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacebookLogo.TabIndex = 68;
            this.FacebookLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(3, 87);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 56;
            this.pictureBoxProfile.TabStop = false;
            // 
            // m_FeedButton
            // 
            this.m_FeedButton.Location = new System.Drawing.Point(3, 171);
            this.m_FeedButton.Name = "m_FeedButton";
            this.m_FeedButton.Size = new System.Drawing.Size(75, 23);
            this.m_FeedButton.TabIndex = 57;
            this.m_FeedButton.Text = "Feed";
            this.m_FeedButton.UseVisualStyleBackColor = true;
            // 
            // m_ProfileButton
            // 
            this.m_ProfileButton.Location = new System.Drawing.Point(3, 200);
            this.m_ProfileButton.Name = "m_ProfileButton";
            this.m_ProfileButton.Size = new System.Drawing.Size(75, 23);
            this.m_ProfileButton.TabIndex = 69;
            this.m_ProfileButton.Text = "Profile";
            this.m_ProfileButton.UseVisualStyleBackColor = true;
            this.m_ProfileButton.Click += new System.EventHandler(this.m_ProfileButton_Click);
            // 
            // postComponent1
            // 
            this.postComponent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.postComponent1.Location = new System.Drawing.Point(366, 3);
            this.postComponent1.Name = "postComponent1";
            this.postComponent1.Size = new System.Drawing.Size(409, 152);
            this.postComponent1.TabIndex = 70;
            // 
            // FacebookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_Menu);
            this.Controls.Add(this.Main);
            this.Name = "FacebookMainForm";
            this.Load += new System.EventHandler(this.FacebookMain_Load);
            this.Main.ResumeLayout(false);
            this.m_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UI.Components.BioComponent m_BioComponent;
        private UI.Components.PostComponent postComponent1;
    }
}