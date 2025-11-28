namespace BasicFacebookFeatures.UI.Components
{
    partial class AlbumsGridComponent
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
            this.pictureContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureContainer
            // 
            this.pictureContainer.AutoSize = true;
            this.pictureContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureContainer.BackColor = System.Drawing.Color.Transparent;
            this.pictureContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureContainer.Location = new System.Drawing.Point(0, 31);
            this.pictureContainer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pictureContainer.Name = "pictureContainer";
            this.pictureContainer.Padding = new System.Windows.Forms.Padding(8);
            this.pictureContainer.Size = new System.Drawing.Size(256, 16);
            this.pictureContainer.TabIndex = 4;
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlbumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsLabel.Location = new System.Drawing.Point(0, 0);
            this.AlbumsLabel.Margin = new System.Windows.Forms.Padding(8);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Padding = new System.Windows.Forms.Padding(8);
            this.AlbumsLabel.Size = new System.Drawing.Size(70, 31);
            this.AlbumsLabel.TabIndex = 7;
            this.AlbumsLabel.Text = "Albums";
            // 
            // AlbumsGridComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureContainer);
            this.Controls.Add(this.AlbumsLabel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(256, 0);
            this.MinimumSize = new System.Drawing.Size(256, 0);
            this.Name = "AlbumsGridComponent";
            this.Size = new System.Drawing.Size(256, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pictureContainer;
        private System.Windows.Forms.Label AlbumsLabel;
    }
}
