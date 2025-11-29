namespace BasicFacebookFeatures.UI.Components
{
    partial class LoginComponent
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
            this.loginFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConnectAsDesig = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.appIdFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.appIdLabel = new System.Windows.Forms.Label();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.LabelError = new System.Windows.Forms.Label();
            this.loginFlowLayoutPanel.SuspendLayout();
            this.appIdFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFlowLayoutPanel
            // 
            this.loginFlowLayoutPanel.AutoSize = true;
            this.loginFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginFlowLayoutPanel.Controls.Add(this.buttonConnectAsDesig);
            this.loginFlowLayoutPanel.Controls.Add(this.divider);
            this.loginFlowLayoutPanel.Controls.Add(this.buttonLogin);
            this.loginFlowLayoutPanel.Controls.Add(this.appIdFlowLayoutPanel);
            this.loginFlowLayoutPanel.Controls.Add(this.LabelError);
            this.loginFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.loginFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginFlowLayoutPanel.Name = "loginFlowLayoutPanel";
            this.loginFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(40);
            this.loginFlowLayoutPanel.Size = new System.Drawing.Size(356, 329);
            this.loginFlowLayoutPanel.TabIndex = 61;
            // 
            // buttonConnectAsDesig
            // 
            this.buttonConnectAsDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectAsDesig.Location = new System.Drawing.Point(44, 44);
            this.buttonConnectAsDesig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectAsDesig.Name = "buttonConnectAsDesig";
            this.buttonConnectAsDesig.Size = new System.Drawing.Size(268, 44);
            this.buttonConnectAsDesig.TabIndex = 58;
            this.buttonConnectAsDesig.Text = "Connect As Desig";
            this.buttonConnectAsDesig.UseVisualStyleBackColor = true;
            this.buttonConnectAsDesig.Click += new System.EventHandler(this.buttonConnectAsDesig_Click);
            // 
            // divider
            // 
            this.divider.Location = new System.Drawing.Point(40, 108);
            this.divider.Margin = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(268, 13);
            this.divider.TabIndex = 59;
            this.divider.Text = "------------------------ Or ------------------------";
            this.divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(44, 141);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 44);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.Text = "Login With Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // appIdFlowLayoutPanel
            // 
            this.appIdFlowLayoutPanel.AutoSize = true;
            this.appIdFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appIdFlowLayoutPanel.Controls.Add(this.appIdLabel);
            this.appIdFlowLayoutPanel.Controls.Add(this.textBoxAppID);
            this.appIdFlowLayoutPanel.Location = new System.Drawing.Point(43, 192);
            this.appIdFlowLayoutPanel.Name = "appIdFlowLayoutPanel";
            this.appIdFlowLayoutPanel.Size = new System.Drawing.Size(268, 32);
            this.appIdFlowLayoutPanel.TabIndex = 63;
            // 
            // appIdLabel
            // 
            this.appIdLabel.Location = new System.Drawing.Point(8, 8);
            this.appIdLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.appIdLabel.Name = "appIdLabel";
            this.appIdLabel.Size = new System.Drawing.Size(41, 13);
            this.appIdLabel.TabIndex = 64;
            this.appIdLabel.Text = "App Id:";
            this.appIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(53, 4);
            this.textBoxAppID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAppID.MinimumSize = new System.Drawing.Size(4, 24);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(211, 20);
            this.textBoxAppID.TabIndex = 63;
            this.textBoxAppID.Text = "1181495753935380";
            // 
            // LabelError
            // 
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(40, 243);
            this.LabelError.Margin = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(268, 30);
            this.LabelError.TabIndex = 65;
            this.LabelError.Text = "Error Message";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelError.Visible = false;
            // 
            // LoginComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.loginFlowLayoutPanel);
            this.Name = "LoginComponent";
            this.Size = new System.Drawing.Size(356, 329);
            this.loginFlowLayoutPanel.ResumeLayout(false);
            this.loginFlowLayoutPanel.PerformLayout();
            this.appIdFlowLayoutPanel.ResumeLayout(false);
            this.appIdFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel loginFlowLayoutPanel;
        private System.Windows.Forms.Button buttonConnectAsDesig;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.FlowLayoutPanel appIdFlowLayoutPanel;
        private System.Windows.Forms.Label appIdLabel;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Label LabelError;
    }
}
