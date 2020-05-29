namespace goodNewServerSwitcher
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChange = new System.Windows.Forms.Button();
            this.txtBoxHosts = new System.Windows.Forms.TextBox();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.txtBoxCertPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblCertPath = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(652, 40);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtBoxHosts
            // 
            this.txtBoxHosts.Location = new System.Drawing.Point(13, 14);
            this.txtBoxHosts.Multiline = true;
            this.txtBoxHosts.Name = "txtBoxHosts";
            this.txtBoxHosts.ReadOnly = true;
            this.txtBoxHosts.Size = new System.Drawing.Size(588, 383);
            this.txtBoxHosts.TabIndex = 1;
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(633, 14);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(130, 20);
            this.txtBoxIP.TabIndex = 2;
            // 
            // txtBoxCertPath
            // 
            this.txtBoxCertPath.Location = new System.Drawing.Point(97, 406);
            this.txtBoxCertPath.Name = "txtBoxCertPath";
            this.txtBoxCertPath.Size = new System.Drawing.Size(441, 20);
            this.txtBoxCertPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(544, 403);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(544, 432);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblCertPath
            // 
            this.lblCertPath.AutoSize = true;
            this.lblCertPath.Location = new System.Drawing.Point(10, 409);
            this.lblCertPath.Name = "lblCertPath";
            this.lblCertPath.Size = new System.Drawing.Size(81, 13);
            this.lblCertPath.TabIndex = 5;
            this.lblCertPath.Text = "Certificate path:";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Location = new System.Drawing.Point(637, 464);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(126, 13);
            this.lblMadeBy.TabIndex = 5;
            this.lblMadeBy.Text = "Made by Edythator, 2020";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(607, 17);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP:";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(10, 464);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(472, 13);
            this.lblInformation.TabIndex = 6;
            this.lblInformation.Text = "Press Change once to clear a preexisting server, then press it again to switch to" +
    " the wanted server.";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblCertPath);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxCertPath);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.txtBoxHosts);
            this.Controls.Add(this.btnChange);
            this.Name = "mainForm";
            this.Text = "GoodServerSwitcher";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtBoxHosts;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.TextBox txtBoxCertPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblCertPath;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblInformation;
    }
}

