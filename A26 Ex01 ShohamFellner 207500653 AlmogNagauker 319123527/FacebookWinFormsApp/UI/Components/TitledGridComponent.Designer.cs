namespace BasicFacebookFeatures.UI.Components
{
    partial class TitledGridComponent
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
            this.ItemsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(8);
            this.labelTitle.Size = new System.Drawing.Size(256, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Tag = "Title";
            this.labelTitle.Text = "Title";
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AutoScroll = true;
            this.ItemsGrid.AutoSize = true;
            this.ItemsGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGrid.Location = new System.Drawing.Point(0, 32);
            this.ItemsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsGrid.MaximumSize = new System.Drawing.Size(256, 500);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.Size = new System.Drawing.Size(256, 118);
            this.ItemsGrid.TabIndex = 1;
            // 
            // TitledGridComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemsGrid);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(256, 0);
            this.Name = "TitledGridComponent";
            this.Size = new System.Drawing.Size(256, 150);
            this.Tag = "PanelBackground";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel ItemsGrid;
    }
}
