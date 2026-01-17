namespace BasicFacebookFeatures.UI.Components
{
    partial class PostsGridComponent
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
            this.ItemsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.labelNoPosts = new System.Windows.Forms.Label();
            this.ItemsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AutoSize = true;
            this.ItemsGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemsGrid.Controls.Add(this.TitleLabel);
            this.ItemsGrid.Controls.Add(this.labelNoPosts);
            this.ItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemsGrid.Location = new System.Drawing.Point(0, 0);
            this.ItemsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.Size = new System.Drawing.Size(512, 44);
            this.ItemsGrid.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(8, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TitleLabel.Size = new System.Drawing.Size(112, 15);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Tag = "Title";
            this.TitleLabel.Text = "Title";
            // 
            // labelNoPosts
            // 
            this.labelNoPosts.AutoSize = true;
            this.labelNoPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNoPosts.Location = new System.Drawing.Point(3, 31);
            this.labelNoPosts.Name = "labelNoPosts";
            this.labelNoPosts.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.labelNoPosts.Size = new System.Drawing.Size(122, 13);
            this.labelNoPosts.TabIndex = 1;
            this.labelNoPosts.Tag = "Subtitle";
            this.labelNoPosts.Text = "No Posts to show";
            this.labelNoPosts.Visible = false;
            // 
            // PostsGridComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ItemsGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(512, 0);
            this.MinimumSize = new System.Drawing.Size(512, 20);
            this.Name = "PostsGridComponent";
            this.Size = new System.Drawing.Size(512, 44);
            this.ItemsGrid.ResumeLayout(false);
            this.ItemsGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ItemsGrid;
        private System.Windows.Forms.Label labelNoPosts;
        private System.Windows.Forms.Label TitleLabel;
    }
}
