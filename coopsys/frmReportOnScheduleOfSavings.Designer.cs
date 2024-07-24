namespace coopsys
{
    partial class frmReportOnScheduleOfSavings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportOnScheduleOfSavings));
            this.btnReset = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboYear = new MetroFramework.Controls.MetroComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.grdReportSavings = new MetroFramework.Controls.MetroGrid();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWait = new MetroFramework.Controls.MetroLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.cboxOpenFile = new System.Windows.Forms.CheckBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportSavings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(382, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 31);
            this.btnReset.TabIndex = 62;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 23;
            this.cboYear.Location = new System.Drawing.Point(65, 79);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(110, 29);
            this.cboYear.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboYear.TabIndex = 60;
            this.cboYear.UseSelectable = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnGenerateReport.Enabled = false;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(199, 77);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(177, 31);
            this.btnGenerateReport.TabIndex = 58;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // grdReportSavings
            // 
            this.grdReportSavings.AllowUserToAddRows = false;
            this.grdReportSavings.AllowUserToDeleteRows = false;
            this.grdReportSavings.AllowUserToResizeColumns = false;
            this.grdReportSavings.AllowUserToResizeRows = false;
            this.grdReportSavings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdReportSavings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportSavings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdReportSavings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReportSavings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportSavings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReportSavings.ColumnHeadersHeight = 29;
            this.grdReportSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReportSavings.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReportSavings.EnableHeadersVisualStyles = false;
            this.grdReportSavings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdReportSavings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportSavings.Location = new System.Drawing.Point(21, 123);
            this.grdReportSavings.Margin = new System.Windows.Forms.Padding(2);
            this.grdReportSavings.MultiSelect = false;
            this.grdReportSavings.Name = "grdReportSavings";
            this.grdReportSavings.ReadOnly = true;
            this.grdReportSavings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportSavings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReportSavings.RowHeadersWidth = 51;
            this.grdReportSavings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdReportSavings.RowTemplate.Height = 24;
            this.grdReportSavings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReportSavings.Size = new System.Drawing.Size(586, 353);
            this.grdReportSavings.TabIndex = 57;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\"xlsx\"";
            this.saveFileDialog1.FileName = "Schedule of Sales";
            this.saveFileDialog1.Filter = "\"excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Excel File ";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Location = new System.Drawing.Point(127, 224);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 122);
            this.panel1.TabIndex = 63;
            this.panel1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 97);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Status:";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(149, 37);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(82, 19);
            this.lblWait.TabIndex = 38;
            this.lblWait.Text = "Please wait...";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(33, 65);
            this.progress.Margin = new System.Windows.Forms.Padding(2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(299, 28);
            this.progress.TabIndex = 0;
            // 
            // cboxOpenFile
            // 
            this.cboxOpenFile.AutoSize = true;
            this.cboxOpenFile.Location = new System.Drawing.Point(326, 503);
            this.cboxOpenFile.Name = "cboxOpenFile";
            this.cboxOpenFile.Size = new System.Drawing.Size(115, 17);
            this.cboxOpenFile.TabIndex = 64;
            this.cboxOpenFile.Text = "Open file on export";
            this.cboxOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(453, 490);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(154, 39);
            this.btnExportExcel.TabIndex = 59;
            this.btnExportExcel.Text = "Export To Excel (.xlxs)";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // frmReportOnScheduleOfSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 547);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.grdReportSavings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxOpenFile);
            this.Controls.Add(this.btnExportExcel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportOnScheduleOfSavings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Schedule of Savings";
            ((System.ComponentModel.ISupportInitialize)(this.grdReportSavings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboYear;
        private System.Windows.Forms.Button btnGenerateReport;
        private MetroFramework.Controls.MetroGrid grdReportSavings;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroLabel lblWait;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox cboxOpenFile;
        private System.Windows.Forms.Button btnExportExcel;
    }
}