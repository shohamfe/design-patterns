namespace BasicFacebookFeatures.UI.Components
{
    partial class PostComponent
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
            this.PostText = new System.Windows.Forms.Label();
            this.m_CardHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_HeaderLabelsContiner = new System.Windows.Forms.FlowLayoutPanel();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.PostDate = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CountOfLike = new System.Windows.Forms.Label();
            this.CountOfComments = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.likesPicture = new System.Windows.Forms.PictureBox();
            this.likesLable = new System.Windows.Forms.Label();
            this.commentsPicture = new System.Windows.Forms.PictureBox();
            this.commentsLable = new System.Windows.Forms.Label();
            this.m_CardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.m_HeaderLabelsContiner.SuspendLayout();
            this.Card.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostText.Location = new System.Drawing.Point(8, 64);
            this.PostText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(161, 13);
            this.PostText.TabIndex = 60;
            this.PostText.Text = "Post text";
            // 
            // m_CardHeader
            // 
            this.m_CardHeader.AutoSize = true;
            this.m_CardHeader.Controls.Add(this.postAuthorProfilePicture);
            this.m_CardHeader.Controls.Add(this.m_HeaderLabelsContiner);
            this.m_CardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CardHeader.Location = new System.Drawing.Point(4, 4);
            this.m_CardHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_CardHeader.Name = "m_CardHeader";
            this.m_CardHeader.Size = new System.Drawing.Size(169, 48);
            this.m_CardHeader.TabIndex = 58;
            // 
            // postAuthorProfilePicture
            // 
            this.postAuthorProfilePicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.place_holder;
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(4, 4);
            this.postAuthorProfilePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postAuthorProfilePicture.Name = "postAuthorProfilePicture";
            this.postAuthorProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.postAuthorProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postAuthorProfilePicture.TabIndex = 58;
            this.postAuthorProfilePicture.TabStop = false;
            // 
            // m_HeaderLabelsContiner
            // 
            this.m_HeaderLabelsContiner.AutoSize = true;
            this.m_HeaderLabelsContiner.Controls.Add(this.PostAuthorName);
            this.m_HeaderLabelsContiner.Controls.Add(this.PostDate);
            this.m_HeaderLabelsContiner.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_HeaderLabelsContiner.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.m_HeaderLabelsContiner.Location = new System.Drawing.Point(52, 4);
            this.m_HeaderLabelsContiner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_HeaderLabelsContiner.Name = "m_HeaderLabelsContiner";
            this.m_HeaderLabelsContiner.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.m_HeaderLabelsContiner.Size = new System.Drawing.Size(45, 40);
            this.m_HeaderLabelsContiner.TabIndex = 60;
            // 
            // PostAuthorName
            // 
            this.PostAuthorName.AutoSize = true;
            this.PostAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostAuthorName.Location = new System.Drawing.Point(3, 7);
            this.PostAuthorName.Name = "PostAuthorName";
            this.PostAuthorName.Size = new System.Drawing.Size(39, 13);
            this.PostAuthorName.TabIndex = 60;
            this.PostAuthorName.Text = "Name";
            // 
            // PostDate
            // 
            this.PostDate.AutoSize = true;
            this.PostDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PostDate.Location = new System.Drawing.Point(3, 20);
            this.PostDate.Name = "PostDate";
            this.PostDate.Size = new System.Drawing.Size(25, 12);
            this.PostDate.TabIndex = 61;
            this.PostDate.Text = "Date";
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card.Controls.Add(this.m_CardHeader);
            this.Card.Controls.Add(this.PostText);
            this.Card.Controls.Add(this.flowLayoutPanel3);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(384, 182);
            this.Card.TabIndex = 69;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 105);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(171, 74);
            this.flowLayoutPanel3.TabIndex = 63;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CountOfLike);
            this.flowLayoutPanel1.Controls.Add(this.CountOfComments);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.flowLayoutPanel1.TabIndex = 62;
            // 
            // CountOfLike
            // 
            this.CountOfLike.AutoSize = true;
            this.CountOfLike.Location = new System.Drawing.Point(8, 8);
            this.CountOfLike.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.CountOfLike.Name = "CountOfLike";
            this.CountOfLike.Size = new System.Drawing.Size(44, 13);
            this.CountOfLike.TabIndex = 63;
            this.CountOfLike.Text = "likesCnt";
            // 
            // CountOfComments
            // 
            this.CountOfComments.AutoSize = true;
            this.CountOfComments.Location = new System.Drawing.Point(68, 8);
            this.CountOfComments.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.CountOfComments.Name = "CountOfComments";
            this.CountOfComments.Size = new System.Drawing.Size(71, 13);
            this.CountOfComments.TabIndex = 61;
            this.CountOfComments.Text = "commentsCnt";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.likesPicture);
            this.flowLayoutPanel2.Controls.Add(this.likesLable);
            this.flowLayoutPanel2.Controls.Add(this.commentsPicture);
            this.flowLayoutPanel2.Controls.Add(this.commentsLable);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 41);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 29);
            this.flowLayoutPanel2.TabIndex = 63;
            // 
            // likesPicture
            // 
            this.likesPicture.Image = global::BasicFacebookFeatures.Properties.Resources.download;
            this.likesPicture.Location = new System.Drawing.Point(4, 4);
            this.likesPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.likesPicture.Name = "likesPicture";
            this.likesPicture.Size = new System.Drawing.Size(16, 17);
            this.likesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesPicture.TabIndex = 62;
            this.likesPicture.TabStop = false;
            // 
            // likesLable
            // 
            this.likesLable.AutoSize = true;
            this.likesLable.Location = new System.Drawing.Point(32, 8);
            this.likesLable.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.likesLable.Name = "likesLable";
            this.likesLable.Size = new System.Drawing.Size(28, 13);
            this.likesLable.TabIndex = 63;
            this.likesLable.Text = "likes";
            // 
            // commentsPicture
            // 
            this.commentsPicture.Image = global::BasicFacebookFeatures.Properties.Resources.comments_icon;
            this.commentsPicture.Location = new System.Drawing.Point(72, 4);
            this.commentsPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentsPicture.Name = "commentsPicture";
            this.commentsPicture.Size = new System.Drawing.Size(16, 17);
            this.commentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentsPicture.TabIndex = 64;
            this.commentsPicture.TabStop = false;
            // 
            // commentsLable
            // 
            this.commentsLable.AutoSize = true;
            this.commentsLable.Location = new System.Drawing.Point(100, 8);
            this.commentsLable.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.commentsLable.Name = "commentsLable";
            this.commentsLable.Size = new System.Drawing.Size(55, 13);
            this.commentsLable.TabIndex = 61;
            this.commentsLable.Text = "comments";
            // 
            // PostComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Card);
            this.MinimumSize = new System.Drawing.Size(384, 0);
            this.Name = "PostComponent";
            this.Size = new System.Drawing.Size(384, 182);
            this.m_CardHeader.ResumeLayout(false);
            this.m_CardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.m_HeaderLabelsContiner.ResumeLayout(false);
            this.m_HeaderLabelsContiner.PerformLayout();
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PostText;
        private System.Windows.Forms.FlowLayoutPanel m_CardHeader;
        private System.Windows.Forms.PictureBox postAuthorProfilePicture;
        private System.Windows.Forms.FlowLayoutPanel m_HeaderLabelsContiner;
        private System.Windows.Forms.Label PostAuthorName;
        private System.Windows.Forms.Label PostDate;
        private System.Windows.Forms.FlowLayoutPanel Card;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label CountOfLike;
        private System.Windows.Forms.Label CountOfComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox likesPicture;
        private System.Windows.Forms.Label likesLable;
        private System.Windows.Forms.PictureBox commentsPicture;
        private System.Windows.Forms.Label commentsLable;
    }
}
