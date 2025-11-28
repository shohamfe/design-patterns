using System;

namespace BasicFacebookFeatures
{
    partial class MainForm
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
            this.m_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.m_FeedButton = new System.Windows.Forms.Button();
            this.m_ProfileButton = new System.Windows.Forms.Button();
            this.m_ProfileName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ProfileNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.m_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.ProfileNamePanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogoContainer.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Menu
            // 
            this.m_Menu.BackColor = System.Drawing.Color.White;
            this.m_Menu.Controls.Add(this.LogoContainer);
            this.m_Menu.Controls.Add(this.ProfileNamePanel);
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
            // m_FeedButton
            // 
            this.m_FeedButton.Location = new System.Drawing.Point(4, 112);
            this.m_FeedButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_FeedButton.Name = "m_FeedButton";
            this.m_FeedButton.Size = new System.Drawing.Size(192, 23);
            this.m_FeedButton.TabIndex = 57;
            this.m_FeedButton.Text = "Feed";
            this.m_FeedButton.UseVisualStyleBackColor = true;
            // 
            // m_ProfileButton
            // 
            this.m_ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.m_ProfileButton.FlatAppearance.BorderSize = 5;
            this.m_ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.m_ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_ProfileButton.Location = new System.Drawing.Point(4, 143);
            this.m_ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_ProfileButton.Name = "m_ProfileButton";
            this.m_ProfileButton.Size = new System.Drawing.Size(192, 23);
            this.m_ProfileButton.TabIndex = 69;
            this.m_ProfileButton.Text = "Profile";
            this.m_ProfileButton.UseVisualStyleBackColor = true;
            this.m_ProfileButton.Click += new System.EventHandler(this.m_ProfileButton_Click);
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
            // ProfileNamePanel
            // 
            this.ProfileNamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProfileNamePanel.Controls.Add(this.pictureBoxProfile);
            this.ProfileNamePanel.Controls.Add(this.m_ProfileName);
            this.ProfileNamePanel.Controls.Add(this.flowLayoutPanel2);
            this.ProfileNamePanel.Location = new System.Drawing.Point(0, 60);
            this.ProfileNamePanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ProfileNamePanel.Name = "ProfileNamePanel";
            this.ProfileNamePanel.Size = new System.Drawing.Size(200, 44);
            this.ProfileNamePanel.TabIndex = 70;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 48);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 44);
            this.flowLayoutPanel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 13, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Profile Name";
            // 
            // LogoContainer
            // 
            this.LogoContainer.Controls.Add(this.FacebookLogo);
            this.LogoContainer.Controls.Add(this.LogoLabel);
            this.LogoContainer.Controls.Add(this.flowLayoutPanel3);
            this.LogoContainer.Location = new System.Drawing.Point(0, 4);
            this.LogoContainer.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(200, 48);
            this.LogoContainer.TabIndex = 72;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LogoLabel.Location = new System.Drawing.Point(52, 13);
            this.LogoLabel.Margin = new System.Windows.Forms.Padding(4, 13, 4, 4);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(123, 20);
            this.LogoLabel.TabIndex = 57;
            this.LogoLabel.Text = "Facebook Lite";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 44);
            this.flowLayoutPanel3.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 13, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Profile Name";
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_round_color;
            this.FacebookLogo.Location = new System.Drawing.Point(4, 4);
            this.FacebookLogo.Margin = new System.Windows.Forms.Padding(4);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(40, 40);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FacebookLogo.TabIndex = 73;
            this.FacebookLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_Menu);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.FacebookMainForm_Load);
            this.m_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ProfileNamePanel.ResumeLayout(false);
            this.ProfileNamePanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogoContainer.ResumeLayout(false);
            this.LogoContainer.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel m_Menu;
        private System.Windows.Forms.Button m_FeedButton;
        private System.Windows.Forms.Button m_ProfileButton;
        private System.Windows.Forms.FlowLayoutPanel ProfileNamePanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label m_ProfileName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel LogoContainer;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
    }
}