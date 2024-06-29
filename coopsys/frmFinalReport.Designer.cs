namespace coopsys
{
    partial class frmFinalReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalReport));
            this.grdFinalReport = new MetroFramework.Controls.MetroGrid();
            this.txtPercent1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPercent2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboYear = new MetroFramework.Controls.MetroComboBox();
            this.txtNetSurplus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboxOpenFile = new System.Windows.Forms.CheckBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWait = new MetroFramework.Controls.MetroLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdFinalReport
            // 
            this.grdFinalReport.AllowUserToAddRows = false;
            this.grdFinalReport.AllowUserToDeleteRows = false;
            this.grdFinalReport.AllowUserToResizeColumns = false;
            this.grdFinalReport.AllowUserToResizeRows = false;
            this.grdFinalReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFinalReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFinalReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFinalReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdFinalReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFinalReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdFinalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFinalReport.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdFinalReport.EnableHeadersVisualStyles = false;
            this.grdFinalReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdFinalReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFinalReport.Location = new System.Drawing.Point(30, 208);
            this.grdFinalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdFinalReport.MultiSelect = false;
            this.grdFinalReport.Name = "grdFinalReport";
            this.grdFinalReport.ReadOnly = true;
            this.grdFinalReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFinalReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdFinalReport.RowHeadersWidth = 51;
            this.grdFinalReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdFinalReport.RowTemplate.Height = 24;
            this.grdFinalReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinalReport.Size = new System.Drawing.Size(934, 433);
            this.grdFinalReport.TabIndex = 38;
            // 
            // txtPercent1
            // 
            // 
            // 
            // 
            this.txtPercent1.CustomButton.Image = null;
            this.txtPercent1.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtPercent1.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercent1.CustomButton.Name = "";
            this.txtPercent1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPercent1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPercent1.CustomButton.TabIndex = 1;
            this.txtPercent1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPercent1.CustomButton.UseSelectable = true;
            this.txtPercent1.CustomButton.Visible = false;
            this.txtPercent1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPercent1.Lines = new string[] {
        "70"};
            this.txtPercent1.Location = new System.Drawing.Point(139, 92);
            this.txtPercent1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercent1.MaxLength = 10;
            this.txtPercent1.Name = "txtPercent1";
            this.txtPercent1.PasswordChar = '\0';
            this.txtPercent1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPercent1.SelectedText = "";
            this.txtPercent1.SelectionLength = 0;
            this.txtPercent1.SelectionStart = 0;
            this.txtPercent1.ShortcutsEnabled = true;
            this.txtPercent1.Size = new System.Drawing.Size(143, 34);
            this.txtPercent1.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPercent1.TabIndex = 39;
            this.txtPercent1.Text = "70";
            this.txtPercent1.UseSelectable = true;
            this.txtPercent1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPercent1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 98);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Percent 1";
            // 
            // txtPercent2
            // 
            // 
            // 
            // 
            this.txtPercent2.CustomButton.Image = null;
            this.txtPercent2.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtPercent2.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercent2.CustomButton.Name = "";
            this.txtPercent2.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPercent2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPercent2.CustomButton.TabIndex = 1;
            this.txtPercent2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPercent2.CustomButton.UseSelectable = true;
            this.txtPercent2.CustomButton.Visible = false;
            this.txtPercent2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPercent2.Lines = new string[] {
        "30"};
            this.txtPercent2.Location = new System.Drawing.Point(468, 92);
            this.txtPercent2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercent2.MaxLength = 10;
            this.txtPercent2.Name = "txtPercent2";
            this.txtPercent2.PasswordChar = '\0';
            this.txtPercent2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPercent2.SelectedText = "";
            this.txtPercent2.SelectionLength = 0;
            this.txtPercent2.SelectionStart = 0;
            this.txtPercent2.ShortcutsEnabled = true;
            this.txtPercent2.Size = new System.Drawing.Size(143, 34);
            this.txtPercent2.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPercent2.TabIndex = 41;
            this.txtPercent2.Text = "30";
            this.txtPercent2.UseSelectable = true;
            this.txtPercent2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPercent2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(359, 98);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 20);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Percent 2";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(392, 148);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 24;
            this.cboYear.Location = new System.Drawing.Point(468, 146);
            this.cboYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(145, 30);
            this.cboYear.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboYear.TabIndex = 43;
            this.cboYear.UseSelectable = true;
            // 
            // txtNetSurplus
            // 
            // 
            // 
            // 
            this.txtNetSurplus.CustomButton.Image = null;
            this.txtNetSurplus.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtNetSurplus.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetSurplus.CustomButton.Name = "";
            this.txtNetSurplus.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNetSurplus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetSurplus.CustomButton.TabIndex = 1;
            this.txtNetSurplus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetSurplus.CustomButton.UseSelectable = true;
            this.txtNetSurplus.CustomButton.Visible = false;
            this.txtNetSurplus.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNetSurplus.Lines = new string[0];
            this.txtNetSurplus.Location = new System.Drawing.Point(139, 142);
            this.txtNetSurplus.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetSurplus.MaxLength = 10;
            this.txtNetSurplus.Name = "txtNetSurplus";
            this.txtNetSurplus.PasswordChar = '\0';
            this.txtNetSurplus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetSurplus.SelectedText = "";
            this.txtNetSurplus.SelectionLength = 0;
            this.txtNetSurplus.SelectionStart = 0;
            this.txtNetSurplus.ShortcutsEnabled = true;
            this.txtNetSurplus.Size = new System.Drawing.Size(143, 34);
            this.txtNetSurplus.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtNetSurplus.TabIndex = 45;
            this.txtNetSurplus.UseSelectable = true;
            this.txtNetSurplus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetSurplus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 148);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 20);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Net Surplus";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(716, 88);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(252, 38);
            this.btnGenerateReport.TabIndex = 47;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnReset.Location = new System.Drawing.Point(716, 138);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(252, 38);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // cboxOpenFile
            // 
            this.cboxOpenFile.AutoSize = true;
            this.cboxOpenFile.Location = new System.Drawing.Point(584, 681);
            this.cboxOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.cboxOpenFile.Name = "cboxOpenFile";
            this.cboxOpenFile.Size = new System.Drawing.Size(140, 20);
            this.cboxOpenFile.TabIndex = 57;
            this.cboxOpenFile.Text = "Open file on export";
            this.cboxOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(759, 665);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(205, 48);
            this.btnExportExcel.TabIndex = 56;
            this.btnExportExcel.Text = "Export To Excel (.xlxs)";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Location = new System.Drawing.Point(252, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 150);
            this.panel1.TabIndex = 58;
            this.panel1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(41, 119);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Status:";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(199, 46);
            this.lblWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(86, 20);
            this.lblWait.TabIndex = 38;
            this.lblWait.Text = "Please wait...";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(44, 80);
            this.progress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(399, 34);
            this.progress.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\"xlsx\"";
            this.saveFileDialog1.FileName = "Loan";
            this.saveFileDialog1.Filter = "\"excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Excel File ";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // frmFinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxOpenFile);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.txtNetSurplus);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.txtPercent2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPercent1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.grdFinalReport);
            this.Name = "frmFinalReport";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Final Report";
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdFinalReport;
        private MetroFramework.Controls.MetroTextBox txtPercent1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPercent2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboYear;
        private MetroFramework.Controls.MetroTextBox txtNetSurplus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cboxOpenFile;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroLabel lblWait;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}