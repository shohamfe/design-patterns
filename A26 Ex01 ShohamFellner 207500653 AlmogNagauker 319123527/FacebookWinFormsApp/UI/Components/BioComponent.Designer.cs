namespace BasicFacebookFeatures.UI.Components
{
    partial class BioComponent
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
            this.m_BioPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.m_FullNameLabel = new System.Windows.Forms.Label();
            this.m_BioLinkLabel = new System.Windows.Forms.LinkLabel();
            this.m_BioLabel = new System.Windows.Forms.Label();
            this.m_BioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_BioPanel
            // 
            this.m_BioPanel.AutoSize = true;
            this.m_BioPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_BioPanel.BackColor = System.Drawing.Color.Transparent;
            this.m_BioPanel.Controls.Add(this.m_FullNameLabel);
            this.m_BioPanel.Controls.Add(this.m_BioLinkLabel);
            this.m_BioPanel.Controls.Add(this.m_BioLabel);
            this.m_BioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_BioPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.m_BioPanel.Location = new System.Drawing.Point(0, 0);
            this.m_BioPanel.Name = "m_BioPanel";
            this.m_BioPanel.Padding = new System.Windows.Forms.Padding(10);
            this.m_BioPanel.Size = new System.Drawing.Size(269, 253);
            this.m_BioPanel.TabIndex = 68;
            // 
            // m_FullNameLabel
            // 
            this.m_FullNameLabel.AutoSize = true;
            this.m_FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FullNameLabel.Location = new System.Drawing.Point(13, 10);
            this.m_FullNameLabel.Name = "m_FullNameLabel";
            this.m_FullNameLabel.Size = new System.Drawing.Size(202, 37);
            this.m_FullNameLabel.TabIndex = 64;
            this.m_FullNameLabel.Text = "<Full Name>";
            // 
            // m_BioLinkLabel
            // 
            this.m_BioLinkLabel.AutoSize = true;
            this.m_BioLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BioLinkLabel.Location = new System.Drawing.Point(13, 47);
            this.m_BioLinkLabel.Name = "m_BioLinkLabel";
            this.m_BioLinkLabel.Size = new System.Drawing.Size(80, 20);
            this.m_BioLinkLabel.TabIndex = 66;
            this.m_BioLinkLabel.TabStop = true;
            this.m_BioLinkLabel.Text = "linkLabel1";
            // 
            // m_BioLabel
            // 
            this.m_BioLabel.AutoSize = true;
            this.m_BioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BioLabel.Location = new System.Drawing.Point(13, 67);
            this.m_BioLabel.Name = "m_BioLabel";
            this.m_BioLabel.Size = new System.Drawing.Size(230, 160);
            this.m_BioLabel.TabIndex = 65;
            this.m_BioLabel.Text = "<Full Name With Middle Name>\r\n<Birthday>\r\n<Email>\r\n<Gender>\r\n<Relationshit Status" +
    ">\r\n<Work>\r\n<HomeTown>\r\n <Languages>";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.m_BioPanel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(269, 253);
            this.m_BioPanel.ResumeLayout(false);
            this.m_BioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel m_BioPanel;
        private System.Windows.Forms.Label m_FullNameLabel;
        private System.Windows.Forms.LinkLabel m_BioLinkLabel;
        private System.Windows.Forms.Label m_BioLabel;
    }
}
