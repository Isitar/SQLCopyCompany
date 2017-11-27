namespace SQLCopyCompany
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourceServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetServer = new System.Windows.Forms.Label();
            this.txtTargetServer = new System.Windows.Forms.TextBox();
            this.cmbSourceCompanies = new System.Windows.Forms.ComboBox();
            this.cmbTargetCompanies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDeleteOldData = new System.Windows.Forms.CheckBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.chkSourceUseWinAuth = new System.Windows.Forms.CheckBox();
            this.chkTargetUseWinAuth = new System.Windows.Forms.CheckBox();
            this.cmdSourceConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSourceDB = new System.Windows.Forms.TextBox();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.txtTargetDB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdTargetConnect = new System.Windows.Forms.Button();
            this.cmdTestSetup = new System.Windows.Forms.Button();
            this.lstInSourceNotInTarget = new System.Windows.Forms.ListBox();
            this.lstInTargetNotInSource = new System.Windows.Forms.ListBox();
            this.cmdShowLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpSource.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourceServer
            // 
            this.txtSourceServer.Location = new System.Drawing.Point(165, 34);
            this.txtSourceServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSourceServer.Name = "txtSourceServer";
            this.txtSourceServer.Size = new System.Drawing.Size(223, 26);
            this.txtSourceServer.TabIndex = 0;
            this.txtSourceServer.Text = "SQNAV01-PROD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Server";
            // 
            // TargetServer
            // 
            this.TargetServer.AutoSize = true;
            this.TargetServer.Location = new System.Drawing.Point(18, 40);
            this.TargetServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetServer.Name = "TargetServer";
            this.TargetServer.Size = new System.Drawing.Size(105, 20);
            this.TargetServer.TabIndex = 4;
            this.TargetServer.Text = "Target Server";
            // 
            // txtTargetServer
            // 
            this.txtTargetServer.Location = new System.Drawing.Point(165, 35);
            this.txtTargetServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetServer.Name = "txtTargetServer";
            this.txtTargetServer.Size = new System.Drawing.Size(223, 26);
            this.txtTargetServer.TabIndex = 100;
            this.txtTargetServer.Text = "SQNAV01-TEST\\SQLEXPRESS";
            // 
            // cmbSourceCompanies
            // 
            this.cmbSourceCompanies.FormattingEnabled = true;
            this.cmbSourceCompanies.Location = new System.Drawing.Point(165, 145);
            this.cmbSourceCompanies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSourceCompanies.Name = "cmbSourceCompanies";
            this.cmbSourceCompanies.Size = new System.Drawing.Size(223, 28);
            this.cmbSourceCompanies.TabIndex = 40;
            // 
            // cmbTargetCompanies
            // 
            this.cmbTargetCompanies.FormattingEnabled = true;
            this.cmbTargetCompanies.Location = new System.Drawing.Point(165, 146);
            this.cmbTargetCompanies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTargetCompanies.Name = "cmbTargetCompanies";
            this.cmbTargetCompanies.Size = new System.Drawing.Size(223, 28);
            this.cmbTargetCompanies.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Source Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Target Company";
            // 
            // chkDeleteOldData
            // 
            this.chkDeleteOldData.AutoSize = true;
            this.chkDeleteOldData.Location = new System.Drawing.Point(165, 188);
            this.chkDeleteOldData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDeleteOldData.Name = "chkDeleteOldData";
            this.chkDeleteOldData.Size = new System.Drawing.Size(22, 21);
            this.chkDeleteOldData.TabIndex = 150;
            this.chkDeleteOldData.UseVisualStyleBackColor = true;
            // 
            // cmdGo
            // 
            this.cmdGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGo.Location = new System.Drawing.Point(733, 984);
            this.cmdGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(128, 35);
            this.cmdGo.TabIndex = 400;
            this.cmdGo.Text = "Go";
            this.cmdGo.UseVisualStyleBackColor = true;
            // 
            // chkSourceUseWinAuth
            // 
            this.chkSourceUseWinAuth.AutoSize = true;
            this.chkSourceUseWinAuth.Checked = true;
            this.chkSourceUseWinAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSourceUseWinAuth.Location = new System.Drawing.Point(165, 114);
            this.chkSourceUseWinAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSourceUseWinAuth.Name = "chkSourceUseWinAuth";
            this.chkSourceUseWinAuth.Size = new System.Drawing.Size(22, 21);
            this.chkSourceUseWinAuth.TabIndex = 20;
            this.chkSourceUseWinAuth.UseVisualStyleBackColor = true;
            // 
            // chkTargetUseWinAuth
            // 
            this.chkTargetUseWinAuth.AutoSize = true;
            this.chkTargetUseWinAuth.Checked = true;
            this.chkTargetUseWinAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTargetUseWinAuth.Location = new System.Drawing.Point(165, 115);
            this.chkTargetUseWinAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTargetUseWinAuth.Name = "chkTargetUseWinAuth";
            this.chkTargetUseWinAuth.Size = new System.Drawing.Size(22, 21);
            this.chkTargetUseWinAuth.TabIndex = 120;
            this.chkTargetUseWinAuth.UseVisualStyleBackColor = true;
            // 
            // cmdSourceConnect
            // 
            this.cmdSourceConnect.Location = new System.Drawing.Point(399, 108);
            this.cmdSourceConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSourceConnect.Name = "cmdSourceConnect";
            this.cmdSourceConnect.Size = new System.Drawing.Size(94, 31);
            this.cmdSourceConnect.TabIndex = 30;
            this.cmdSourceConnect.Text = "Connect";
            this.cmdSourceConnect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "WinAuth";
            // 
            // grpSource
            // 
            this.grpSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSource.Controls.Add(this.label8);
            this.grpSource.Controls.Add(this.txtSourceDB);
            this.grpSource.Controls.Add(this.label1);
            this.grpSource.Controls.Add(this.label5);
            this.grpSource.Controls.Add(this.txtSourceServer);
            this.grpSource.Controls.Add(this.cmdSourceConnect);
            this.grpSource.Controls.Add(this.cmbSourceCompanies);
            this.grpSource.Controls.Add(this.label3);
            this.grpSource.Controls.Add(this.chkSourceUseWinAuth);
            this.grpSource.Location = new System.Drawing.Point(18, 18);
            this.grpSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSource.Name = "grpSource";
            this.grpSource.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSource.Size = new System.Drawing.Size(851, 211);
            this.grpSource.TabIndex = 18;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Surce";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Source DB";
            // 
            // txtSourceDB
            // 
            this.txtSourceDB.Location = new System.Drawing.Point(165, 74);
            this.txtSourceDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSourceDB.Name = "txtSourceDB";
            this.txtSourceDB.Size = new System.Drawing.Size(223, 26);
            this.txtSourceDB.TabIndex = 10;
            this.txtSourceDB.Text = "sqpr_nav_prod";
            // 
            // grpTarget
            // 
            this.grpTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTarget.Controls.Add(this.txtTargetDB);
            this.grpTarget.Controls.Add(this.label9);
            this.grpTarget.Controls.Add(this.label7);
            this.grpTarget.Controls.Add(this.label6);
            this.grpTarget.Controls.Add(this.cmdTargetConnect);
            this.grpTarget.Controls.Add(this.txtTargetServer);
            this.grpTarget.Controls.Add(this.chkTargetUseWinAuth);
            this.grpTarget.Controls.Add(this.chkDeleteOldData);
            this.grpTarget.Controls.Add(this.TargetServer);
            this.grpTarget.Controls.Add(this.cmbTargetCompanies);
            this.grpTarget.Controls.Add(this.label4);
            this.grpTarget.Location = new System.Drawing.Point(18, 238);
            this.grpTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTarget.Size = new System.Drawing.Size(851, 231);
            this.grpTarget.TabIndex = 19;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Target";
            // 
            // txtTargetDB
            // 
            this.txtTargetDB.Location = new System.Drawing.Point(165, 75);
            this.txtTargetDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetDB.Name = "txtTargetDB";
            this.txtTargetDB.Size = new System.Drawing.Size(223, 26);
            this.txtTargetDB.TabIndex = 110;
            this.txtTargetDB.Text = "sqpr_nav_test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Target DB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "DeleteOldData";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "WinAuth";
            // 
            // cmdTargetConnect
            // 
            this.cmdTargetConnect.Location = new System.Drawing.Point(399, 111);
            this.cmdTargetConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTargetConnect.Name = "cmdTargetConnect";
            this.cmdTargetConnect.Size = new System.Drawing.Size(94, 31);
            this.cmdTargetConnect.TabIndex = 130;
            this.cmdTargetConnect.Text = "Connect";
            this.cmdTargetConnect.UseVisualStyleBackColor = true;
            // 
            // cmdTestSetup
            // 
            this.cmdTestSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTestSetup.Location = new System.Drawing.Point(731, 863);
            this.cmdTestSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTestSetup.Name = "cmdTestSetup";
            this.cmdTestSetup.Size = new System.Drawing.Size(128, 35);
            this.cmdTestSetup.TabIndex = 200;
            this.cmdTestSetup.Text = "TestSetup";
            this.cmdTestSetup.UseVisualStyleBackColor = true;
            // 
            // lstInSourceNotInTarget
            // 
            this.lstInSourceNotInTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInSourceNotInTarget.FormattingEnabled = true;
            this.lstInSourceNotInTarget.ItemHeight = 20;
            this.lstInSourceNotInTarget.Location = new System.Drawing.Point(18, 498);
            this.lstInSourceNotInTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstInSourceNotInTarget.Name = "lstInSourceNotInTarget";
            this.lstInSourceNotInTarget.Size = new System.Drawing.Size(705, 164);
            this.lstInSourceNotInTarget.TabIndex = 9999;
            // 
            // lstInTargetNotInSource
            // 
            this.lstInTargetNotInSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInTargetNotInSource.FormattingEnabled = true;
            this.lstInTargetNotInSource.ItemHeight = 20;
            this.lstInTargetNotInSource.Location = new System.Drawing.Point(21, 752);
            this.lstInTargetNotInSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstInTargetNotInSource.Name = "lstInTargetNotInSource";
            this.lstInTargetNotInSource.Size = new System.Drawing.Size(702, 144);
            this.lstInTargetNotInSource.TabIndex = 9999;
            // 
            // cmdShowLog
            // 
            this.cmdShowLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdShowLog.Location = new System.Drawing.Point(731, 907);
            this.cmdShowLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdShowLog.Name = "cmdShowLog";
            this.cmdShowLog.Size = new System.Drawing.Size(128, 35);
            this.cmdShowLog.TabIndex = 300;
            this.cmdShowLog.Text = "Show Log";
            this.cmdShowLog.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 474);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Not in Target but in Source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 727);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Not in Target but in Source";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(18, 667);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(76, 20);
            this.lblProgress.TabIndex = 10000;
            this.lblProgress.Text = "Progress:";
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressValue.AutoSize = true;
            this.lblProgressValue.Location = new System.Drawing.Point(18, 687);
            this.lblProgressValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(118, 20);
            this.lblProgressValue.TabIndex = 10001;
            this.lblProgressValue.Text = "Table 0 / 10000";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(22, 911);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(702, 112);
            this.txtLog.TabIndex = 10002;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 1038);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblProgressValue);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdShowLog);
            this.Controls.Add(this.lstInTargetNotInSource);
            this.Controls.Add(this.lstInSourceNotInTarget);
            this.Controls.Add(this.cmdTestSetup);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.cmdGo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "SQLCopyCompany";
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TargetServer;
        private System.Windows.Forms.TextBox txtTargetServer;
        private System.Windows.Forms.ComboBox cmbSourceCompanies;
        private System.Windows.Forms.ComboBox cmbTargetCompanies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDeleteOldData;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.CheckBox chkSourceUseWinAuth;
        private System.Windows.Forms.CheckBox chkTargetUseWinAuth;
        private System.Windows.Forms.Button cmdSourceConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdTargetConnect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSourceDB;
        private System.Windows.Forms.TextBox txtTargetDB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdTestSetup;
        private System.Windows.Forms.ListBox lstInSourceNotInTarget;
        private System.Windows.Forms.ListBox lstInTargetNotInSource;
        private System.Windows.Forms.Button cmdShowLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.TextBox txtLog;
    }
}

