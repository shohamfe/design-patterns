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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CountOfLike = new System.Windows.Forms.Label();
            this.CountOfComments = new System.Windows.Forms.Label();
            this.PostText = new System.Windows.Forms.Label();
            this.m_CardHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_HeaderLabelsContiner = new System.Windows.Forms.FlowLayoutPanel();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.PostDate = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.likesLable = new System.Windows.Forms.Label();
            this.commentsLable = new System.Windows.Forms.Label();
            this.likesPicture = new System.Windows.Forms.PictureBox();
            this.commentsPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.m_CardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.m_HeaderLabelsContiner.SuspendLayout();
            this.Card.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CountOfLike);
            this.flowLayoutPanel1.Controls.Add(this.CountOfComments);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 36);
            this.flowLayoutPanel1.TabIndex = 61;
            // 
            // CountOfLike
            // 
            this.CountOfLike.AutoSize = true;
            this.CountOfLike.Location = new System.Drawing.Point(11, 10);
            this.CountOfLike.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.CountOfLike.Name = "CountOfLike";
            this.CountOfLike.Size = new System.Drawing.Size(35, 16);
            this.CountOfLike.TabIndex = 63;
            this.CountOfLike.Text = "likes";
            // 
            // CountOfComments
            // 
            this.CountOfComments.AutoSize = true;
            this.CountOfComments.Location = new System.Drawing.Point(68, 10);
            this.CountOfComments.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.CountOfComments.Name = "CountOfComments";
            this.CountOfComments.Size = new System.Drawing.Size(69, 16);
            this.CountOfComments.TabIndex = 61;
            this.CountOfComments.Text = "comments";
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Location = new System.Drawing.Point(11, 79);
            this.PostText.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(57, 16);
            this.PostText.TabIndex = 60;
            this.PostText.Text = "Post text";
            // 
            // m_CardHeader
            // 
            this.m_CardHeader.AutoSize = true;
            this.m_CardHeader.Controls.Add(this.postAuthorProfilePicture);
            this.m_CardHeader.Controls.Add(this.m_HeaderLabelsContiner);
            this.m_CardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CardHeader.Location = new System.Drawing.Point(5, 5);
            this.m_CardHeader.Margin = new System.Windows.Forms.Padding(5);
            this.m_CardHeader.Name = "m_CardHeader";
            this.m_CardHeader.Size = new System.Drawing.Size(210, 59);
            this.m_CardHeader.TabIndex = 58;
            // 
            // postAuthorProfilePicture
            // 
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(5, 5);
            this.postAuthorProfilePicture.Margin = new System.Windows.Forms.Padding(5);
            this.postAuthorProfilePicture.Name = "postAuthorProfilePicture";
            this.postAuthorProfilePicture.Size = new System.Drawing.Size(53, 49);
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
            this.m_HeaderLabelsContiner.Location = new System.Drawing.Point(68, 5);
            this.m_HeaderLabelsContiner.Margin = new System.Windows.Forms.Padding(5);
            this.m_HeaderLabelsContiner.Name = "m_HeaderLabelsContiner";
            this.m_HeaderLabelsContiner.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.m_HeaderLabelsContiner.Size = new System.Drawing.Size(57, 49);
            this.m_HeaderLabelsContiner.TabIndex = 60;
            // 
            // PostAuthorName
            // 
            this.PostAuthorName.AutoSize = true;
            this.PostAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostAuthorName.Location = new System.Drawing.Point(4, 9);
            this.PostAuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostAuthorName.Name = "PostAuthorName";
            this.PostAuthorName.Size = new System.Drawing.Size(49, 17);
            this.PostAuthorName.TabIndex = 60;
            this.PostAuthorName.Text = "Name";
            // 
            // PostDate
            // 
            this.PostDate.AutoSize = true;
            this.PostDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PostDate.Location = new System.Drawing.Point(4, 26);
            this.PostDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostDate.Name = "PostDate";
            this.PostDate.Size = new System.Drawing.Size(33, 15);
            this.PostDate.TabIndex = 61;
            this.PostDate.Text = "Date";
            // 
            // Card
            // 
            this.Card.Controls.Add(this.m_CardHeader);
            this.Card.Controls.Add(this.PostText);
            this.Card.Controls.Add(this.flowLayoutPanel1);
            this.Card.Controls.Add(this.flowLayoutPanel2);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Margin = new System.Windows.Forms.Padding(4);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(533, 197);
            this.Card.TabIndex = 69;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.likesPicture);
            this.flowLayoutPanel2.Controls.Add(this.likesLable);
            this.flowLayoutPanel2.Controls.Add(this.commentsPicture);
            this.flowLayoutPanel2.Controls.Add(this.commentsLable);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 156);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 36);
            this.flowLayoutPanel2.TabIndex = 62;
            // 
            // likesLable
            // 
            this.likesLable.AutoSize = true;
            this.likesLable.Location = new System.Drawing.Point(42, 10);
            this.likesLable.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.likesLable.Name = "likesLable";
            this.likesLable.Size = new System.Drawing.Size(35, 16);
            this.likesLable.TabIndex = 63;
            this.likesLable.Text = "likes";
            // 
            // commentsLable
            // 
            this.commentsLable.AutoSize = true;
            this.commentsLable.Location = new System.Drawing.Point(130, 10);
            this.commentsLable.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.commentsLable.Name = "commentsLable";
            this.commentsLable.Size = new System.Drawing.Size(69, 16);
            this.commentsLable.TabIndex = 61;
            this.commentsLable.Text = "comments";
            // 
            // likesPicture
            // 
            this.likesPicture.Location = new System.Drawing.Point(5, 5);
            this.likesPicture.Margin = new System.Windows.Forms.Padding(5);
            this.likesPicture.Name = "likesPicture";
            this.likesPicture.Size = new System.Drawing.Size(21, 21);
            this.likesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesPicture.TabIndex = 62;
            this.likesPicture.TabStop = false;
            // 
            // commentsPicture
            // 
            this.commentsPicture.Location = new System.Drawing.Point(93, 5);
            this.commentsPicture.Margin = new System.Windows.Forms.Padding(5);
            this.commentsPicture.Name = "commentsPicture";
            this.commentsPicture.Size = new System.Drawing.Size(21, 21);
            this.commentsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentsPicture.TabIndex = 64;
            this.commentsPicture.TabStop = false;
            // 
            // PostComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Card);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PostComponent";
            this.Size = new System.Drawing.Size(533, 197);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.m_CardHeader.ResumeLayout(false);
            this.m_CardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.m_HeaderLabelsContiner.ResumeLayout(false);
            this.m_HeaderLabelsContiner.PerformLayout();
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label PostText;
        private System.Windows.Forms.FlowLayoutPanel m_CardHeader;
        private System.Windows.Forms.PictureBox postAuthorProfilePicture;
        private System.Windows.Forms.FlowLayoutPanel m_HeaderLabelsContiner;
        private System.Windows.Forms.Label PostAuthorName;
        private System.Windows.Forms.Label PostDate;
        private System.Windows.Forms.FlowLayoutPanel Card;
        private System.Windows.Forms.Label CountOfLike;
        private System.Windows.Forms.Label CountOfComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox likesPicture;
        private System.Windows.Forms.Label likesLable;
        private System.Windows.Forms.PictureBox commentsPicture;
        private System.Windows.Forms.Label commentsLable;
    }
}
