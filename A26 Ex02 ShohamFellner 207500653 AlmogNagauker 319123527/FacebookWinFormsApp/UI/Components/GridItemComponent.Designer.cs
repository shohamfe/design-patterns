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
            this.labelTitle = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitle.Location = new System.Drawing.Point(4, 79);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Tag = "Title";
            this.labelTitle.Text = "label";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.place_holder;
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
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GridItemComponent";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(80, 96);
            this.Tag = "PanelBackground";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}
