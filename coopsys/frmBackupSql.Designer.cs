﻿namespace coopsys
{
    partial class frmBackupSql
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
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(20, 110);
            this.progress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(406, 28);
            this.progress.TabIndex = 0;
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(443, 110);
            this.btnStartBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(78, 28);
            this.btnStartBackup.TabIndex = 1;
            this.btnStartBackup.Text = "Backup";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            this.btnStartBackup.Click += new System.EventHandler(this.btnStartBackup_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 85);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: ";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(18, 150);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "Progress:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\"sql\"";
            this.saveFileDialog1.FileName = "backup";
            this.saveFileDialog1.Filter = "\"excel files (*.sql)|*.sql|All files (*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Backup Database";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(443, 44);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 28);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(20, 44);
            this.txtDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDir.Multiline = false;
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(407, 29);
            this.txtDir.TabIndex = 6;
            this.txtDir.Text = "";
            // 
            // frmBackupSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 185);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.progress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupSql";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox txtDir;
    }
}