using System;

namespace BasicFacebookFeatures
{
    partial class FacebookMain
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_Bio = new System.Windows.Forms.Label();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 130);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(105, 96);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 56;
            this.pictureBoxProfile.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 57;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 75);
            this.label1.TabIndex = 63;
            this.label1.Text = "------------\r\n<Interasted in>\r\n<FavoriteTemas>";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 46);
            this.label2.TabIndex = 64;
            this.label2.Text = "<Full Name>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.m_Bio);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(152, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 524);
            this.flowLayoutPanel1.TabIndex = 67;
            // 
            // m_Bio
            // 
            this.m_Bio.AutoSize = true;
            this.m_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Bio.Location = new System.Drawing.Point(17, 58);
            this.m_Bio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Bio.Name = "m_Bio";
            this.m_Bio.Size = new System.Drawing.Size(289, 225);
            this.m_Bio.TabIndex = 65;
            this.m_Bio.Text = "<Full Name With Middle Name>\r\n<Link>\r\n<Birthday>\r\n<Email>\r\n<Gender>\r\n<Relationshi" +
    "t Status>\r\n<Work>\r\n<HomeTown>\r\n <Languages>";
            this.m_Bio.Click += new System.EventHandler(this.label3_Click);
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_round_color;
            this.FacebookLogo.Location = new System.Drawing.Point(16, 26);
            this.FacebookLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(105, 96);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FacebookLogo.TabIndex = 68;
            this.FacebookLogo.TabStop = false;
            // 
            // FacebookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FacebookLogo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacebookMain";
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FacebookMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label m_Bio;
        private System.Windows.Forms.PictureBox FacebookLogo;
    }
}