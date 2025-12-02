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
            this.panelBio = new System.Windows.Forms.FlowLayoutPanel();
            this.m_FullNameLabel = new System.Windows.Forms.Label();
            this.linkLabelBio = new System.Windows.Forms.LinkLabel();
            this.labelBio = new System.Windows.Forms.Label();
            this.panelBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBio
            // 
            this.panelBio.AutoSize = true;
            this.panelBio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBio.BackColor = System.Drawing.Color.White;
            this.panelBio.Controls.Add(this.m_FullNameLabel);
            this.panelBio.Controls.Add(this.linkLabelBio);
            this.panelBio.Controls.Add(this.labelBio);
            this.panelBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBio.Location = new System.Drawing.Point(0, 0);
            this.panelBio.Margin = new System.Windows.Forms.Padding(0);
            this.panelBio.Name = "panelBio";
            this.panelBio.Padding = new System.Windows.Forms.Padding(8);
            this.panelBio.Size = new System.Drawing.Size(256, 183);
            this.panelBio.TabIndex = 68;
            this.panelBio.Tag = "PanelBackground";
            // 
            // m_FullNameLabel
            // 
            this.m_FullNameLabel.AutoSize = true;
            this.m_FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FullNameLabel.Location = new System.Drawing.Point(12, 12);
            this.m_FullNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.m_FullNameLabel.Name = "m_FullNameLabel";
            this.m_FullNameLabel.Size = new System.Drawing.Size(138, 26);
            this.m_FullNameLabel.TabIndex = 64;
            this.m_FullNameLabel.Tag = "Title";
            this.m_FullNameLabel.Text = "<Full Name>";
            // 
            // linkLabelBio
            // 
            this.linkLabelBio.AutoSize = true;
            this.linkLabelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBio.Location = new System.Drawing.Point(12, 46);
            this.linkLabelBio.Margin = new System.Windows.Forms.Padding(4);
            this.linkLabelBio.Name = "linkLabelBio";
            this.linkLabelBio.Size = new System.Drawing.Size(55, 13);
            this.linkLabelBio.TabIndex = 66;
            this.linkLabelBio.TabStop = true;
            this.linkLabelBio.Text = "linkLabel1";
            this.linkLabelBio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_BioLinkLabel_LinkClicked);
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio.Location = new System.Drawing.Point(12, 67);
            this.labelBio.Margin = new System.Windows.Forms.Padding(4);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(156, 104);
            this.labelBio.TabIndex = 65;
            this.labelBio.Tag = "Title";
            this.labelBio.Text = "<Full Name With Middle Name>\r\n<Birthday>\r\n<Email>\r\n<Gender>\r\n<Relationship Status" +
    ">\r\n<Work>\r\n<HomeTown>\r\n<Languages>";
            // 
            // BioComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelBio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(256, 0);
            this.Name = "BioComponent";
            this.Size = new System.Drawing.Size(256, 183);
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelBio;
        private System.Windows.Forms.Label m_FullNameLabel;
        private System.Windows.Forms.LinkLabel linkLabelBio;
        private System.Windows.Forms.Label labelBio;
    }
}
