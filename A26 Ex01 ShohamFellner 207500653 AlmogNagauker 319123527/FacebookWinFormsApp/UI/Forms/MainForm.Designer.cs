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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProfileNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.m_ProfileName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_FeedButton = new System.Windows.Forms.Button();
            this.CloseFriendsFeedbutton = new System.Windows.Forms.Button();
            this.m_ProfileButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sidePanel.SuspendLayout();
            this.LogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.ProfileNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Controls.Add(this.LogoContainer);
            this.sidePanel.Controls.Add(this.menuPanel);
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(201, 491);
            this.sidePanel.TabIndex = 72;
            // 
            // LogoContainer
            // 
            this.LogoContainer.Controls.Add(this.FacebookLogo);
            this.LogoContainer.Controls.Add(this.LogoLabel);
            this.LogoContainer.Controls.Add(this.flowLayoutPanel3);
            this.LogoContainer.Location = new System.Drawing.Point(4, 4);
            this.LogoContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(192, 48);
            this.LogoContainer.TabIndex = 72;
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Location = new System.Drawing.Point(4, 4);
            this.FacebookLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(40, 40);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FacebookLogo.TabIndex = 73;
            this.FacebookLogo.TabStop = false;
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
            // menuPanel
            // 
            this.menuPanel.AutoSize = true;
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.Controls.Add(this.ProfileNamePanel);
            this.menuPanel.Controls.Add(this.m_FeedButton);
            this.menuPanel.Controls.Add(this.CloseFriendsFeedbutton);
            this.menuPanel.Controls.Add(this.m_ProfileButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 56);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 153);
            this.menuPanel.TabIndex = 73;
            this.menuPanel.Visible = false;
            // 
            // ProfileNamePanel
            // 
            this.ProfileNamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProfileNamePanel.Controls.Add(this.pictureBoxProfile);
            this.ProfileNamePanel.Controls.Add(this.m_ProfileName);
            this.ProfileNamePanel.Controls.Add(this.flowLayoutPanel2);
            this.ProfileNamePanel.Location = new System.Drawing.Point(0, 4);
            this.ProfileNamePanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ProfileNamePanel.Name = "ProfileNamePanel";
            this.ProfileNamePanel.Size = new System.Drawing.Size(200, 52);
            this.ProfileNamePanel.TabIndex = 73;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.InitialImage")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
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
            this.m_ProfileName.Location = new System.Drawing.Point(56, 17);
            this.m_ProfileName.Margin = new System.Windows.Forms.Padding(4, 17, 4, 4);
            this.m_ProfileName.Name = "m_ProfileName";
            this.m_ProfileName.Size = new System.Drawing.Size(101, 17);
            this.m_ProfileName.TabIndex = 57;
            this.m_ProfileName.Text = "Profile Name";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 44);
            this.flowLayoutPanel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // m_FeedButton
            // 
            this.m_FeedButton.Location = new System.Drawing.Point(4, 64);
            this.m_FeedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_FeedButton.Name = "m_FeedButton";
            this.m_FeedButton.Size = new System.Drawing.Size(192, 23);
            this.m_FeedButton.TabIndex = 71;
            this.m_FeedButton.Text = "Feed";
            this.m_FeedButton.UseVisualStyleBackColor = true;
            this.m_FeedButton.Click += new System.EventHandler(this.m_FeedButton_Click);
            // 
            // CloseFriendsFeedbutton
            // 
            this.CloseFriendsFeedbutton.Location = new System.Drawing.Point(4, 95);
            this.CloseFriendsFeedbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseFriendsFeedbutton.Name = "CloseFriendsFeedbutton";
            this.CloseFriendsFeedbutton.Size = new System.Drawing.Size(192, 23);
            this.CloseFriendsFeedbutton.TabIndex = 75;
            this.CloseFriendsFeedbutton.Text = "Close Friends Feed";
            this.CloseFriendsFeedbutton.UseVisualStyleBackColor = true;
            this.CloseFriendsFeedbutton.Click += new System.EventHandler(this.CLoseFriendsFeedButton_Click);
            // 
            // m_ProfileButton
            // 
            this.m_ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.m_ProfileButton.FlatAppearance.BorderSize = 5;
            this.m_ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.m_ProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_ProfileButton.Location = new System.Drawing.Point(4, 126);
            this.m_ProfileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ProfileButton.Name = "m_ProfileButton";
            this.m_ProfileButton.Size = new System.Drawing.Size(192, 23);
            this.m_ProfileButton.TabIndex = 72;
            this.m_ProfileButton.Text = "Profile";
            this.m_ProfileButton.UseVisualStyleBackColor = true;
            this.m_ProfileButton.Click += new System.EventHandler(this.m_ProfileButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.logoutButton.FlatAppearance.BorderSize = 5;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutButton.Location = new System.Drawing.Point(4, 249);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 40, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(192, 23);
            this.logoutButton.TabIndex = 74;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(201, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(605, 491);
            this.mainPanel.TabIndex = 73;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Facebook Lite";
            this.Load += new System.EventHandler(this.FacebookMainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.LogoContainer.ResumeLayout(false);
            this.LogoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ProfileNamePanel.ResumeLayout(false);
            this.ProfileNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.FlowLayoutPanel LogoContainer;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.FlowLayoutPanel ProfileNamePanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label m_ProfileName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_FeedButton;
        private System.Windows.Forms.Button m_ProfileButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Button CloseFriendsFeedbutton;
        private System.Windows.Forms.ImageList imageList1;
    }
}