namespace coopsys
{
    partial class frmReportInterestOnCapitalShare
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportInterestOnCapitalShare));
            this.btnReset = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboYear = new MetroFramework.Controls.MetroComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.grdReportInterestOnShareCapital = new MetroFramework.Controls.MetroGrid();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWait = new MetroFramework.Controls.MetroLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cboxOpenFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportInterestOnShareCapital)).BeginInit();
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
            this.btnReset.Location = new System.Drawing.Point(705, 98);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(235, 106);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 20);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 24;
            this.cboYear.Items.AddRange(new object[] {
            "2024"});
            this.cboYear.Location = new System.Drawing.Point(292, 102);
            this.cboYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(145, 30);
            this.cboYear.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboYear.TabIndex = 48;
            this.cboYear.UseSelectable = true;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
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
            this.btnGenerateReport.Location = new System.Drawing.Point(467, 98);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(231, 38);
            this.btnGenerateReport.TabIndex = 46;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // grdReportInterestOnShareCapital
            // 
            this.grdReportInterestOnShareCapital.AllowUserToAddRows = false;
            this.grdReportInterestOnShareCapital.AllowUserToDeleteRows = false;
            this.grdReportInterestOnShareCapital.AllowUserToResizeRows = false;
            this.grdReportInterestOnShareCapital.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportInterestOnShareCapital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdReportInterestOnShareCapital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReportInterestOnShareCapital.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportInterestOnShareCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReportInterestOnShareCapital.ColumnHeadersHeight = 29;
            this.grdReportInterestOnShareCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReportInterestOnShareCapital.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReportInterestOnShareCapital.EnableHeadersVisualStyles = false;
            this.grdReportInterestOnShareCapital.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdReportInterestOnShareCapital.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportInterestOnShareCapital.Location = new System.Drawing.Point(23, 156);
            this.grdReportInterestOnShareCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdReportInterestOnShareCapital.MultiSelect = false;
            this.grdReportInterestOnShareCapital.Name = "grdReportInterestOnShareCapital";
            this.grdReportInterestOnShareCapital.ReadOnly = true;
            this.grdReportInterestOnShareCapital.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportInterestOnShareCapital.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReportInterestOnShareCapital.RowHeadersWidth = 51;
            this.grdReportInterestOnShareCapital.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdReportInterestOnShareCapital.RowTemplate.Height = 24;
            this.grdReportInterestOnShareCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReportInterestOnShareCapital.Size = new System.Drawing.Size(781, 434);
            this.grdReportInterestOnShareCapital.TabIndex = 45;
            this.grdReportInterestOnShareCapital.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdReportInterestOnShareCapital_ColumnHeaderMouseClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(599, 607);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(205, 48);
            this.btnExportExcel.TabIndex = 47;
            this.btnExportExcel.Text = "Export To Excel (.xlxs)";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\"xlsx\"";
            this.saveFileDialog1.FileName = "Capital Share Interest";
            this.saveFileDialog1.Filter = "\"excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Excel File ";
            // 
            // txtRate
            // 
            // 
            // 
            // 
            this.txtRate.CustomButton.Image = null;
            this.txtRate.CustomButton.Location = new System.Drawing.Point(77, 2);
            this.txtRate.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.CustomButton.Name = "";
            this.txtRate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRate.CustomButton.TabIndex = 1;
            this.txtRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRate.CustomButton.UseSelectable = true;
            this.txtRate.CustomButton.Visible = false;
            this.txtRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRate.Lines = new string[0];
            this.txtRate.Location = new System.Drawing.Point(85, 103);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 10;
            this.txtRate.Name = "txtRate";
            this.txtRate.PasswordChar = '\0';
            this.txtRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRate.SelectedText = "";
            this.txtRate.SelectionLength = 0;
            this.txtRate.SelectionStart = 0;
            this.txtRate.ShortcutsEnabled = true;
            this.txtRate.Size = new System.Drawing.Size(109, 34);
            this.txtRate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtRate.TabIndex = 51;
            this.txtRate.UseSelectable = true;
            this.txtRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 106);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 20);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Rate";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Location = new System.Drawing.Point(171, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 150);
            this.panel1.TabIndex = 53;
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
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // cboxOpenFile
            // 
            this.cboxOpenFile.AutoSize = true;
            this.cboxOpenFile.Location = new System.Drawing.Point(423, 622);
            this.cboxOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.cboxOpenFile.Name = "cboxOpenFile";
            this.cboxOpenFile.Size = new System.Drawing.Size(140, 20);
            this.cboxOpenFile.TabIndex = 54;
            this.cboxOpenFile.Text = "Open file on export";
            this.cboxOpenFile.UseVisualStyleBackColor = true;
            // 
            // frmReportInterestOnCapitalShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 687);
            this.Controls.Add(this.cboxOpenFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.grdReportInterestOnShareCapital);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmReportInterestOnCapitalShare";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Interest on Capital Share";
            this.Load += new System.EventHandler(this.frmReportInterestOnCapitalShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportInterestOnShareCapital)).EndInit();
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
        private System.Windows.Forms.Button btnExportExcel;
        private MetroFramework.Controls.MetroGrid grdReportInterestOnShareCapital;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtRate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroLabel lblWait;
        private System.Windows.Forms.ProgressBar progress;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cboxOpenFile;
    }
}