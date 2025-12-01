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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostComponent));
            this.Card = new System.Windows.Forms.FlowLayoutPanel();
            this.m_CardHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_HeaderLabelsContiner = new System.Windows.Forms.FlowLayoutPanel();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.PostDate = new System.Windows.Forms.Label();
            this.buttonCloseFriends = new System.Windows.Forms.Button();
            this.imageListStar = new System.Windows.Forms.ImageList(this.components);
            this.PostText = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CountOfLike = new System.Windows.Forms.Label();
            this.CountOfComments = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLike = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonComment = new System.Windows.Forms.Button();
            this.Card.SuspendLayout();
            this.m_CardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.m_HeaderLabelsContiner.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.countPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
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
            this.Card.Size = new System.Drawing.Size(384, 153);
            this.Card.TabIndex = 69;
            // 
            // m_CardHeader
            // 
            this.m_CardHeader.AutoSize = true;
            this.m_CardHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_CardHeader.Controls.Add(this.postAuthorProfilePicture);
            this.m_CardHeader.Controls.Add(this.m_HeaderLabelsContiner);
            this.m_CardHeader.Controls.Add(this.buttonCloseFriends);
            this.m_CardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CardHeader.Location = new System.Drawing.Point(4, 4);
            this.m_CardHeader.Margin = new System.Windows.Forms.Padding(4);
            this.m_CardHeader.Name = "m_CardHeader";
            this.m_CardHeader.Size = new System.Drawing.Size(279, 48);
            this.m_CardHeader.TabIndex = 58;
            // 
            // postAuthorProfilePicture
            // 
            this.postAuthorProfilePicture.ImageLocation = "Resources/MockData/ProfilePicturesJhon Davis.png";
            this.postAuthorProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("postAuthorProfilePicture.InitialImage")));
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(4, 4);
            this.postAuthorProfilePicture.Margin = new System.Windows.Forms.Padding(4);
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
            this.m_HeaderLabelsContiner.Margin = new System.Windows.Forms.Padding(4);
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
            // buttonCloseFriends
            // 
            this.buttonCloseFriends.AutoSize = true;
            this.buttonCloseFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCloseFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseFriends.FlatAppearance.BorderSize = 0;
            this.buttonCloseFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseFriends.ImageIndex = 0;
            this.buttonCloseFriends.ImageList = this.imageListStar;
            this.buttonCloseFriends.Location = new System.Drawing.Point(141, 4);
            this.buttonCloseFriends.Margin = new System.Windows.Forms.Padding(40, 4, 4, 4);
            this.buttonCloseFriends.Name = "buttonCloseFriends";
            this.buttonCloseFriends.Size = new System.Drawing.Size(134, 40);
            this.buttonCloseFriends.TabIndex = 61;
            this.buttonCloseFriends.Text = "Add To Close Friends";
            this.buttonCloseFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCloseFriends.UseVisualStyleBackColor = true;
            this.buttonCloseFriends.Visible = false;
            this.buttonCloseFriends.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // imageListStar
            // 
            this.imageListStar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStar.ImageStream")));
            this.imageListStar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStar.Images.SetKeyName(0, "star.png");
            this.imageListStar.Images.SetKeyName(1, "star-fill.png");
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostText.Location = new System.Drawing.Point(8, 64);
            this.PostText.Margin = new System.Windows.Forms.Padding(8);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(271, 13);
            this.PostText.TabIndex = 60;
            this.PostText.Text = "Post text";
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
            this.bottomPanel.Size = new System.Drawing.Size(279, 44);
            this.bottomPanel.TabIndex = 63;
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
            this.countPanel.Size = new System.Drawing.Size(150, 13);
            this.countPanel.TabIndex = 62;
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
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.Controls.Add(this.buttonLike);
            this.buttonsPanel.Controls.Add(this.buttonComment);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 13);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(150, 31);
            this.buttonsPanel.TabIndex = 63;
            // 
            // buttonLike
            // 
            this.buttonLike.ImageIndex = 0;
            this.buttonLike.ImageList = this.imageListIcons;
            this.buttonLike.Location = new System.Drawing.Point(4, 4);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(57, 23);
            this.buttonLike.TabIndex = 65;
            this.buttonLike.Text = "Like";
            this.buttonLike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "like-icon.png");
            this.imageListIcons.Images.SetKeyName(1, "comments-icon.png");
            // 
            // buttonComment
            // 
            this.buttonComment.ImageIndex = 1;
            this.buttonComment.ImageList = this.imageListIcons;
            this.buttonComment.Location = new System.Drawing.Point(69, 4);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(77, 23);
            this.buttonComment.TabIndex = 66;
            this.buttonComment.Text = "Comment";
            this.buttonComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
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
            this.Size = new System.Drawing.Size(384, 153);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.m_CardHeader.ResumeLayout(false);
            this.m_CardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.m_HeaderLabelsContiner.ResumeLayout(false);
            this.m_HeaderLabelsContiner.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.ImageList imageListStar;
        private System.Windows.Forms.Button buttonCloseFriends;
    }
}
