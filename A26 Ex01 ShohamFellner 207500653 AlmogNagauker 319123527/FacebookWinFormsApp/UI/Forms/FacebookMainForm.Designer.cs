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
            this.components = new System.ComponentModel.Container();
            this.Main = new System.Windows.Forms.FlowLayoutPanel();
            this.m_BioPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.m_FullNameLabel = new System.Windows.Forms.Label();
            this.m_BioLinkLabel = new System.Windows.Forms.LinkLabel();
            this.m_BioLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.m_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.m_FeedButton = new System.Windows.Forms.Button();
            this.m_ProfileButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bioForm1 = new BasicFacebookFeatures.UI.Forms.BioForm(this.components);
            this.Main.SuspendLayout();
            this.m_BioPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.m_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.m_BioPanel);
            this.Main.Controls.Add(this.flowLayoutPanel1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(88, 0, 0, 0);
            this.Main.Size = new System.Drawing.Size(800, 450);
            this.Main.TabIndex = 70;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // m_BioPanel
            // 
            this.m_BioPanel.AutoSize = true;
            this.m_BioPanel.BackColor = System.Drawing.Color.Transparent;
            this.m_BioPanel.Controls.Add(this.m_FullNameLabel);
            this.m_BioPanel.Controls.Add(this.m_BioLinkLabel);
            this.m_BioPanel.Controls.Add(this.m_BioLabel);
            this.m_BioPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_BioPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.m_BioPanel.Location = new System.Drawing.Point(91, 3);
            this.m_BioPanel.Name = "m_BioPanel";
            this.m_BioPanel.Padding = new System.Windows.Forms.Padding(10);
            this.m_BioPanel.Size = new System.Drawing.Size(256, 237);
            this.m_BioPanel.TabIndex = 67;
            // 
            // m_FullNameLabel
            // 
            this.m_FullNameLabel.AutoSize = true;
            this.m_FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FullNameLabel.Location = new System.Drawing.Point(13, 10);
            this.m_FullNameLabel.Name = "m_FullNameLabel";
            this.m_FullNameLabel.Size = new System.Drawing.Size(202, 37);
            this.m_FullNameLabel.TabIndex = 64;
            this.m_FullNameLabel.Text = "<Full Name>";
            // 
            // m_BioLinkLabel
            // 
            this.m_BioLinkLabel.AutoSize = true;
            this.m_BioLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BioLinkLabel.Location = new System.Drawing.Point(13, 47);
            this.m_BioLinkLabel.Name = "m_BioLinkLabel";
            this.m_BioLinkLabel.Size = new System.Drawing.Size(80, 20);
            this.m_BioLinkLabel.TabIndex = 66;
            this.m_BioLinkLabel.TabStop = true;
            this.m_BioLinkLabel.Text = "linkLabel1";
            // 
            // m_BioLabel
            // 
            this.m_BioLabel.AutoSize = true;
            this.m_BioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BioLabel.Location = new System.Drawing.Point(13, 67);
            this.m_BioLabel.Name = "m_BioLabel";
            this.m_BioLabel.Size = new System.Drawing.Size(230, 160);
            this.m_BioLabel.TabIndex = 65;
            this.m_BioLabel.Text = "<Full Name With Middle Name>\r\n<Birthday>\r\n<Email>\r\n<Gender>\r\n<Relationshit Status" +
    ">\r\n<Work>\r\n<HomeTown>\r\n <Languages>";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.Text);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(353, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 130);
            this.flowLayoutPanel1.TabIndex = 68;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 40);
            this.flowLayoutPanel2.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Name);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(49, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(163, 40);
            this.flowLayoutPanel3.TabIndex = 60;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(3, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 60;
            this.Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Date";
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(3, 46);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(48, 13);
            this.Text.TabIndex = 59;
            this.Text.Text = "Post text";
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
            // FacebookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_Menu);
            this.Controls.Add(this.Main);
            this.Load += new System.EventHandler(this.FacebookMain_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.m_BioPanel.ResumeLayout(false);
            this.m_BioPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.m_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Main;
        private System.Windows.Forms.FlowLayoutPanel m_BioPanel;
        private System.Windows.Forms.Label m_FullNameLabel;
        private System.Windows.Forms.LinkLabel m_BioLinkLabel;
        private System.Windows.Forms.Label m_BioLabel;
        private System.Windows.Forms.FlowLayoutPanel m_Menu;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button m_FeedButton;
        private System.Windows.Forms.Button m_ProfileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UI.Forms.BioForm bioForm1;
    }
}