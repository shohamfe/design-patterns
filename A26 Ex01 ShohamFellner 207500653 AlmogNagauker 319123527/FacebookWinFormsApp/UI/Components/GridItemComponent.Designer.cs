namespace BasicFacebookFeatures.Logic.Managers
{
    partial class GridItemComponent
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TitleLabel.Location = new System.Drawing.Point(4, 79);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(72, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "label";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(4, 4);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.MaximumSize = new System.Drawing.Size(72, 72);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(72, 72);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // GridItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GridItemComponent";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(80, 96);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}
