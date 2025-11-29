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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostComponent));
            this.Card = new System.Windows.Forms.FlowLayoutPanel();
            this.m_HeaderLabelsContiner = new System.Windows.Forms.FlowLayoutPanel();
            this.PostDate = new System.Windows.Forms.Label();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_CardHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.PostText = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentsLable = new System.Windows.Forms.Label();
            this.commentsPicture = new System.Windows.Forms.PictureBox();
            this.likesLable = new System.Windows.Forms.Label();
            this.likesPicture = new System.Windows.Forms.PictureBox();
            this.countPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CountOfComments = new System.Windows.Forms.Label();
            this.CountOfLike = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Card.SuspendLayout();
            this.m_HeaderLabelsContiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.m_CardHeader.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).BeginInit();
            this.countPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card.Controls.Add(this.m_CardHeader);
            this.Card.Controls.Add(this.PostText);
            this.Card.Controls.Add(this.bottomPanel);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Margin = new System.Windows.Forms.Padding(4);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(384, 154);
            this.Card.TabIndex = 69;
            // 
            // m_HeaderLabelsContiner
            // 
            this.m_HeaderLabelsContiner.AutoSize = true;
            this.m_HeaderLabelsContiner.Controls.Add(this.PostAuthorName);
            this.m_HeaderLabelsContiner.Controls.Add(this.PostDate);
            this.m_HeaderLabelsContiner.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_HeaderLabelsContiner.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.m_HeaderLabelsContiner.Location = new System.Drawing.Point(52, 4);
            this.m_HeaderLabelsContiner.Margin = new System.Windows.Forms.Padding(4);
            this.m_HeaderLabelsContiner.Name = "m_HeaderLabelsContiner";
            this.m_HeaderLabelsContiner.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.m_HeaderLabelsContiner.Size = new System.Drawing.Size(45, 40);
            this.m_HeaderLabelsContiner.TabIndex = 60;
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
            // postAuthorProfilePicture
            // 
            this.postAuthorProfilePicture.InitialImage = global::BasicFacebookFeatures.Properties.Resources.place_holder;
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(4, 4);
            this.postAuthorProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.postAuthorProfilePicture.Name = "postAuthorProfilePicture";
            this.postAuthorProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.postAuthorProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postAuthorProfilePicture.TabIndex = 58;
            this.postAuthorProfilePicture.TabStop = false;
            // 
            // m_CardHeader
            // 
            this.m_CardHeader.AutoSize = true;
            this.m_CardHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_CardHeader.Controls.Add(this.postAuthorProfilePicture);
            this.m_CardHeader.Controls.Add(this.m_HeaderLabelsContiner);
            this.m_CardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CardHeader.Location = new System.Drawing.Point(4, 4);
            this.m_CardHeader.Margin = new System.Windows.Forms.Padding(4);
            this.m_CardHeader.Name = "m_CardHeader";
            this.m_CardHeader.Size = new System.Drawing.Size(155, 48);
            this.m_CardHeader.TabIndex = 58;
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostText.Location = new System.Drawing.Point(8, 64);
            this.PostText.Margin = new System.Windows.Forms.Padding(8);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(147, 13);
            this.PostText.TabIndex = 60;
            this.PostText.Text = "Post text";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.Controls.Add(this.likesPicture);
            this.buttonsPanel.Controls.Add(this.likesLable);
            this.buttonsPanel.Controls.Add(this.commentsPicture);
            this.buttonsPanel.Controls.Add(this.commentsLable);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 13);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(155, 32);
            this.buttonsPanel.TabIndex = 63;
            // 
            // commentsLable
            // 
            this.commentsLable.AutoSize = true;
            this.commentsLable.Location = new System.Drawing.Point(92, 8);
            this.commentsLable.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.commentsLable.Name = "commentsLable";
            this.commentsLable.Size = new System.Drawing.Size(55, 13);
            this.commentsLable.TabIndex = 61;
            this.commentsLable.Text = "comments";
            // 
            // commentsPicture
            // 
            this.commentsPicture.Image = ((System.Drawing.Image)(resources.GetObject("commentsPicture.Image")));
            this.commentsPicture.Location = new System.Drawing.Point(72, 8);
            this.commentsPicture.Margin = new System.Windows.Forms.Padding(8, 8, 4, 8);
            this.commentsPicture.Name = "commentsPicture";
            this.commentsPicture.Size = new System.Drawing.Size(16, 16);
            this.commentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentsPicture.TabIndex = 64;
            this.commentsPicture.TabStop = false;
            // 
            // likesLable
            // 
            this.likesLable.AutoSize = true;
            this.likesLable.Location = new System.Drawing.Point(28, 8);
            this.likesLable.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.likesLable.Name = "likesLable";
            this.likesLable.Size = new System.Drawing.Size(28, 13);
            this.likesLable.TabIndex = 63;
            this.likesLable.Text = "likes";
            // 
            // likesPicture
            // 
            this.likesPicture.Image = global::BasicFacebookFeatures.Properties.Resources.like_icon;
            this.likesPicture.Location = new System.Drawing.Point(8, 8);
            this.likesPicture.Margin = new System.Windows.Forms.Padding(8, 8, 4, 8);
            this.likesPicture.Name = "likesPicture";
            this.likesPicture.Size = new System.Drawing.Size(16, 16);
            this.likesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesPicture.TabIndex = 62;
            this.likesPicture.TabStop = false;
            // 
            // countPanel
            // 
            this.countPanel.AutoSize = true;
            this.countPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countPanel.Controls.Add(this.CountOfLike);
            this.countPanel.Controls.Add(this.CountOfComments);
            this.countPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.countPanel.Location = new System.Drawing.Point(0, 0);
            this.countPanel.Margin = new System.Windows.Forms.Padding(0);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(155, 13);
            this.countPanel.TabIndex = 62;
            // 
            // CountOfComments
            // 
            this.CountOfComments.AutoSize = true;
            this.CountOfComments.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountOfComments.Location = new System.Drawing.Point(68, 0);
            this.CountOfComments.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CountOfComments.Name = "CountOfComments";
            this.CountOfComments.Size = new System.Drawing.Size(71, 13);
            this.CountOfComments.TabIndex = 61;
            this.CountOfComments.Text = "commentsCnt";
            // 
            // CountOfLike
            // 
            this.CountOfLike.AutoSize = true;
            this.CountOfLike.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountOfLike.Location = new System.Drawing.Point(8, 0);
            this.CountOfLike.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CountOfLike.Name = "CountOfLike";
            this.CountOfLike.Size = new System.Drawing.Size(44, 13);
            this.CountOfLike.TabIndex = 63;
            this.CountOfLike.Text = "likesCnt";
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.Controls.Add(this.countPanel);
            this.bottomPanel.Controls.Add(this.buttonsPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bottomPanel.Location = new System.Drawing.Point(4, 105);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(155, 45);
            this.bottomPanel.TabIndex = 63;
            // 
            // PostComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Card);
            this.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.MinimumSize = new System.Drawing.Size(384, 0);
            this.Name = "PostComponent";
            this.Size = new System.Drawing.Size(384, 154);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.m_HeaderLabelsContiner.ResumeLayout(false);
            this.m_HeaderLabelsContiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.m_CardHeader.ResumeLayout(false);
            this.m_CardHeader.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).EndInit();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Card;
        private System.Windows.Forms.FlowLayoutPanel m_CardHeader;
        private System.Windows.Forms.PictureBox postAuthorProfilePicture;
        private System.Windows.Forms.FlowLayoutPanel m_HeaderLabelsContiner;
        private System.Windows.Forms.Label PostAuthorName;
        private System.Windows.Forms.Label PostDate;
        private System.Windows.Forms.Label PostText;
        private System.Windows.Forms.FlowLayoutPanel bottomPanel;
        private System.Windows.Forms.FlowLayoutPanel countPanel;
        private System.Windows.Forms.Label CountOfLike;
        private System.Windows.Forms.Label CountOfComments;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.PictureBox likesPicture;
        private System.Windows.Forms.Label likesLable;
        private System.Windows.Forms.PictureBox commentsPicture;
        private System.Windows.Forms.Label commentsLable;
    }
}
