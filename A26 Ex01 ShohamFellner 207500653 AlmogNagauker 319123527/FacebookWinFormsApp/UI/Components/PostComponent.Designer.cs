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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.postAuthorProfilePicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PostAuthorName = new System.Windows.Forms.Label();
            this.PostDate = new System.Windows.Forms.Label();
            this.PostText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.PostText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 152);
            this.flowLayoutPanel1.TabIndex = 69;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.postAuthorProfilePicture);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 48);
            this.flowLayoutPanel2.TabIndex = 58;
            // 
            // postAuthorProfilePicture
            // 
            this.postAuthorProfilePicture.Location = new System.Drawing.Point(3, 3);
            this.postAuthorProfilePicture.Name = "postAuthorProfilePicture";
            this.postAuthorProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.postAuthorProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postAuthorProfilePicture.TabIndex = 58;
            this.postAuthorProfilePicture.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.PostAuthorName);
            this.flowLayoutPanel3.Controls.Add(this.PostDate);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(46, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(330, 46);
            this.flowLayoutPanel3.TabIndex = 60;
            // 
            // PostAuthorName
            // 
            this.PostAuthorName.AutoSize = true;
            this.PostAuthorName.Location = new System.Drawing.Point(3, 0);
            this.PostAuthorName.Name = "PostAuthorName";
            this.PostAuthorName.Size = new System.Drawing.Size(35, 13);
            this.PostAuthorName.TabIndex = 60;
            this.PostAuthorName.Text = "Name";
            // 
            // PostDate
            // 
            this.PostDate.AutoSize = true;
            this.PostDate.Location = new System.Drawing.Point(3, 13);
            this.PostDate.Name = "PostDate";
            this.PostDate.Size = new System.Drawing.Size(30, 13);
            this.PostDate.TabIndex = 61;
            this.PostDate.Text = "Date";
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostText.Location = new System.Drawing.Point(3, 56);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(394, 13);
            this.PostText.TabIndex = 59;
            this.PostText.Text = "Post text";
            // 
            // PostComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PostComponent";
            this.Size = new System.Drawing.Size(409, 152);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorProfilePicture)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox postAuthorProfilePicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label PostAuthorName;
        private System.Windows.Forms.Label PostDate;
        private System.Windows.Forms.Label PostText;
    }
}
