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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSideMenuTop = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProfileName = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonCloseFriends = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSideMenuTop.SuspendLayout();
            this.LogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panelProfileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(794, 621);
            this.mainPanel.TabIndex = 73;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelSideMenuTop
            // 
            this.panelSideMenuTop.Controls.Add(this.LogoContainer);
            this.panelSideMenuTop.Controls.Add(this.panelProfileName);
            this.panelSideMenuTop.Controls.Add(this.buttonFeed);
            this.panelSideMenuTop.Controls.Add(this.buttonCloseFriends);
            this.panelSideMenuTop.Controls.Add(this.buttonProfile);
            this.panelSideMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideMenuTop.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSideMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuTop.Name = "panelSideMenuTop";
            this.panelSideMenuTop.Size = new System.Drawing.Size(200, 621);
            this.panelSideMenuTop.TabIndex = 85;
            this.panelSideMenuTop.WrapContents = false;
            // 
            // LogoContainer
            // 
            this.LogoContainer.Controls.Add(this.FacebookLogo);
            this.LogoContainer.Controls.Add(this.LogoLabel);
            this.LogoContainer.Controls.Add(this.flowLayoutPanel3);
            this.LogoContainer.Location = new System.Drawing.Point(8, 16);
            this.LogoContainer.Margin = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(184, 48);
            this.LogoContainer.TabIndex = 85;
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_icon;
            this.FacebookLogo.Location = new System.Drawing.Point(4, 4);
            this.FacebookLogo.Margin = new System.Windows.Forms.Padding(4);
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
            // panelProfileName
            // 
            this.panelProfileName.AutoSize = true;
            this.panelProfileName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelProfileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProfileName.Controls.Add(this.pictureBoxProfile);
            this.panelProfileName.Controls.Add(this.labelUserName);
            this.panelProfileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileName.Location = new System.Drawing.Point(0, 80);
            this.panelProfileName.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panelProfileName.Name = "panelProfileName";
            this.panelProfileName.Size = new System.Drawing.Size(200, 52);
            this.panelProfileName.TabIndex = 86;
            this.panelProfileName.Tag = "SecondaryPanel";
            this.panelProfileName.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.InitialImage")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 56;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(56, 17);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 17, 4, 4);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(101, 17);
            this.labelUserName.TabIndex = 57;
            this.labelUserName.Tag = "Title";
            this.labelUserName.Text = "Profile Name";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(4, 148);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(192, 23);
            this.buttonFeed.TabIndex = 87;
            this.buttonFeed.Tag = "AccentButton";
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Visible = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonCloseFriends
            // 
            this.buttonCloseFriends.Location = new System.Drawing.Point(4, 187);
            this.buttonCloseFriends.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.buttonCloseFriends.Name = "buttonCloseFriends";
            this.buttonCloseFriends.Size = new System.Drawing.Size(192, 23);
            this.buttonCloseFriends.TabIndex = 89;
            this.buttonCloseFriends.Tag = "AccentButton";
            this.buttonCloseFriends.Text = "Close Friends Feed";
            this.buttonCloseFriends.UseVisualStyleBackColor = true;
            this.buttonCloseFriends.Visible = false;
            this.buttonCloseFriends.Click += new System.EventHandler(this.buttonCloseFriends_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonProfile.FlatAppearance.BorderSize = 5;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonProfile.Location = new System.Drawing.Point(4, 226);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(192, 23);
            this.buttonProfile.TabIndex = 88;
            this.buttonProfile.Tag = "AccentButton";
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Visible = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelTheme);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxTheme);
            this.flowLayoutPanel2.Controls.Add(this.buttonLogout);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 532);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 89);
            this.flowLayoutPanel2.TabIndex = 88;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // labelTheme
            // 
            this.labelTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTheme.Location = new System.Drawing.Point(4, 4);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(192, 13);
            this.labelTheme.TabIndex = 82;
            this.labelTheme.Tag = "Subtitle";
            this.labelTheme.Text = "Theme:";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(4, 21);
            this.comboBoxTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(192, 21);
            this.comboBoxTheme.TabIndex = 81;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonLogout.FlatAppearance.BorderSize = 5;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogout.Location = new System.Drawing.Point(4, 58);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(192, 23);
            this.buttonLogout.TabIndex = 83;
            this.buttonLogout.Tag = "AccentButton";
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.Controls.Add(this.flowLayoutPanel2);
            this.panelSideMenu.Controls.Add(this.panelSideMenuTop);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(8);
            this.panelSideMenu.MinimumSize = new System.Drawing.Size(0, 100);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 621);
            this.panelSideMenu.TabIndex = 74;
            this.panelSideMenu.Tag = "PanelBackground";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(994, 621);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Tag = "PrimaryBackground";
            this.Text = "Facebook Lite";
            this.panelSideMenuTop.ResumeLayout(false);
            this.panelSideMenuTop.PerformLayout();
            this.LogoContainer.ResumeLayout(false);
            this.LogoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panelProfileName.ResumeLayout(false);
            this.panelProfileName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel panelSideMenuTop;
        private System.Windows.Forms.FlowLayoutPanel LogoContainer;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel panelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonCloseFriends;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelSideMenu;
    }
}