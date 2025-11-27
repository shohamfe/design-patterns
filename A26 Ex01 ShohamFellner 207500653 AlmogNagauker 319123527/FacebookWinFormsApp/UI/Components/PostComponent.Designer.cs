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
            this.m_CardHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.m_HeaderLabelsContiner = new System.Windows.Forms.FlowLayoutPanel();
            this.PostDate = new System.Windows.Forms.Label();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.Card = new System.Windows.Forms.FlowLayoutPanel();
            this.PostText = new System.Windows.Forms.Label();
            this.m_CardHeader.SuspendLayout();
            this.m_HeaderLabelsContiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CardHeader
            // 
            this.m_CardHeader.AutoSize = true;
            this.m_CardHeader.Controls.Add(this.postAuthorProfilePicture);
            this.m_CardHeader.Controls.Add(this.m_HeaderLabelsContiner);
            this.m_CardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_CardHeader.Location = new System.Drawing.Point(4, 4);
            this.m_CardHeader.Margin = new System.Windows.Forms.Padding(4);
            this.m_CardHeader.Name = "m_CardHeader";
            this.m_CardHeader.Size = new System.Drawing.Size(101, 48);
            this.m_CardHeader.TabIndex = 58;
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
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(4, 4);
            this.postAuthorProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.postAuthorProfilePicture.Name = "postAuthorProfilePicture";
            this.postAuthorProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.postAuthorProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postAuthorProfilePicture.TabIndex = 58;
            this.postAuthorProfilePicture.TabStop = false;
            // 
            // Card
            // 
            this.Card.Controls.Add(this.m_CardHeader);
            this.Card.Controls.Add(this.PostText);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(400, 160);
            this.Card.TabIndex = 69;
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Location = new System.Drawing.Point(8, 64);
            this.PostText.Margin = new System.Windows.Forms.Padding(8);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(48, 13);
            this.PostText.TabIndex = 60;
            this.PostText.Text = "Post text";
            // 
            // PostComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Card);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostComponent";
            this.Size = new System.Drawing.Size(400, 160);
            this.m_CardHeader.ResumeLayout(false);
            this.m_CardHeader.PerformLayout();
            this.m_HeaderLabelsContiner.ResumeLayout(false);
            this.m_HeaderLabelsContiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel m_CardHeader;
        private System.Windows.Forms.PictureBox postAuthorProfilePicture;
        private System.Windows.Forms.FlowLayoutPanel m_HeaderLabelsContiner;
        private System.Windows.Forms.Label PostAuthorName;
        private System.Windows.Forms.Label PostDate;
        private System.Windows.Forms.FlowLayoutPanel Card;
        private System.Windows.Forms.Label PostText;
    }
}
