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
            this.TitleLabel.Location = new System.Drawing.Point(5, 97);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(97, 16);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "label";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.place_holder;
            this.PictureBox.Location = new System.Drawing.Point(5, 5);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.MaximumSize = new System.Drawing.Size(96, 89);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(96, 89);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // GridItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GridItemComponent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(107, 118);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}
