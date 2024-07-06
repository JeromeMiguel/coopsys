namespace coopsys
{
    partial class frmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLoanPenalty = new MetroFramework.Controls.MetroTextBox();
            this.lblPercent1 = new System.Windows.Forms.Label();
            this.txtMemberLoanRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblDefaults = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPercent3 = new System.Windows.Forms.Label();
            this.lblPercent2 = new System.Windows.Forms.Label();
            this.txtFinalPercentage2 = new MetroFramework.Controls.MetroTextBox();
            this.txtFinalPercentage1 = new MetroFramework.Controls.MetroTextBox();
            this.txtInterestCSRate = new MetroFramework.Controls.MetroTextBox();
            this.txtDvidendRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBrowseCertificates = new System.Windows.Forms.Button();
            this.txtSaveCertificates = new MetroFramework.Controls.MetroTextBox();
            this.txtSaveReports = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowseReports = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblEditStatus = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLoanPenalty);
            this.groupBox1.Controls.Add(this.lblPercent1);
            this.groupBox1.Controls.Add(this.txtMemberLoanRate);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(33, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtLoanPenalty
            // 
            this.txtLoanPenalty.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtLoanPenalty.CustomButton.Image = null;
            this.txtLoanPenalty.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtLoanPenalty.CustomButton.Name = "";
            this.txtLoanPenalty.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtLoanPenalty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoanPenalty.CustomButton.TabIndex = 1;
            this.txtLoanPenalty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoanPenalty.CustomButton.UseSelectable = true;
            this.txtLoanPenalty.CustomButton.Visible = false;
            this.txtLoanPenalty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLoanPenalty.Lines = new string[0];
            this.txtLoanPenalty.Location = new System.Drawing.Point(381, 76);
            this.txtLoanPenalty.MaxLength = 10;
            this.txtLoanPenalty.Multiline = true;
            this.txtLoanPenalty.Name = "txtLoanPenalty";
            this.txtLoanPenalty.PasswordChar = '\0';
            this.txtLoanPenalty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoanPenalty.SelectedText = "";
            this.txtLoanPenalty.SelectionLength = 0;
            this.txtLoanPenalty.SelectionStart = 0;
            this.txtLoanPenalty.ShortcutsEnabled = true;
            this.txtLoanPenalty.Size = new System.Drawing.Size(268, 31);
            this.txtLoanPenalty.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtLoanPenalty.TabIndex = 34;
            this.txtLoanPenalty.UseCustomBackColor = true;
            this.txtLoanPenalty.UseSelectable = true;
            this.txtLoanPenalty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoanPenalty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoanPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // lblPercent1
            // 
            this.lblPercent1.AutoSize = true;
            this.lblPercent1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPercent1.Location = new System.Drawing.Point(278, 84);
            this.lblPercent1.Name = "lblPercent1";
            this.lblPercent1.Size = new System.Drawing.Size(19, 16);
            this.lblPercent1.TabIndex = 29;
            this.lblPercent1.Text = "%";
            // 
            // txtMemberLoanRate
            // 
            this.txtMemberLoanRate.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtMemberLoanRate.CustomButton.Image = null;
            this.txtMemberLoanRate.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtMemberLoanRate.CustomButton.Name = "";
            this.txtMemberLoanRate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtMemberLoanRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemberLoanRate.CustomButton.TabIndex = 1;
            this.txtMemberLoanRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemberLoanRate.CustomButton.UseSelectable = true;
            this.txtMemberLoanRate.CustomButton.Visible = false;
            this.txtMemberLoanRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMemberLoanRate.Lines = new string[0];
            this.txtMemberLoanRate.Location = new System.Drawing.Point(38, 76);
            this.txtMemberLoanRate.MaxLength = 6;
            this.txtMemberLoanRate.Multiline = true;
            this.txtMemberLoanRate.Name = "txtMemberLoanRate";
            this.txtMemberLoanRate.PasswordChar = '\0';
            this.txtMemberLoanRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemberLoanRate.SelectedText = "";
            this.txtMemberLoanRate.SelectionLength = 0;
            this.txtMemberLoanRate.SelectionStart = 0;
            this.txtMemberLoanRate.ShortcutsEnabled = true;
            this.txtMemberLoanRate.Size = new System.Drawing.Size(268, 31);
            this.txtMemberLoanRate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtMemberLoanRate.TabIndex = 33;
            this.txtMemberLoanRate.UseCustomBackColor = true;
            this.txtMemberLoanRate.UseSelectable = true;
            this.txtMemberLoanRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemberLoanRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberLoanRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel4.Location = new System.Drawing.Point(381, 49);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 17);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Loan Penalty ( ₱ )";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel3.Location = new System.Drawing.Point(35, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(191, 17);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Member Loan Interst Rate ( % )";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel2.Location = new System.Drawing.Point(16, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Loans";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lblDefaults
            // 
            this.lblDefaults.AutoSize = true;
            this.lblDefaults.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDefaults.Location = new System.Drawing.Point(33, 85);
            this.lblDefaults.Name = "lblDefaults";
            this.lblDefaults.Size = new System.Drawing.Size(68, 20);
            this.lblDefaults.TabIndex = 0;
            this.lblDefaults.Text = "Defaults";
            this.lblDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPercent3);
            this.groupBox2.Controls.Add(this.lblPercent2);
            this.groupBox2.Controls.Add(this.txtFinalPercentage2);
            this.groupBox2.Controls.Add(this.txtFinalPercentage1);
            this.groupBox2.Controls.Add(this.txtInterestCSRate);
            this.groupBox2.Controls.Add(this.txtDvidendRate);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Location = new System.Drawing.Point(33, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 210);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // lblPercent3
            // 
            this.lblPercent3.AutoSize = true;
            this.lblPercent3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPercent3.Location = new System.Drawing.Point(622, 159);
            this.lblPercent3.Name = "lblPercent3";
            this.lblPercent3.Size = new System.Drawing.Size(19, 16);
            this.lblPercent3.TabIndex = 41;
            this.lblPercent3.Text = "%";
            // 
            // lblPercent2
            // 
            this.lblPercent2.AutoSize = true;
            this.lblPercent2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPercent2.Location = new System.Drawing.Point(278, 159);
            this.lblPercent2.Name = "lblPercent2";
            this.lblPercent2.Size = new System.Drawing.Size(19, 16);
            this.lblPercent2.TabIndex = 40;
            this.lblPercent2.Text = "%";
            // 
            // txtFinalPercentage2
            // 
            this.txtFinalPercentage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtFinalPercentage2.CustomButton.Image = null;
            this.txtFinalPercentage2.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtFinalPercentage2.CustomButton.Name = "";
            this.txtFinalPercentage2.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtFinalPercentage2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinalPercentage2.CustomButton.TabIndex = 1;
            this.txtFinalPercentage2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinalPercentage2.CustomButton.UseSelectable = true;
            this.txtFinalPercentage2.CustomButton.Visible = false;
            this.txtFinalPercentage2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFinalPercentage2.Lines = new string[0];
            this.txtFinalPercentage2.Location = new System.Drawing.Point(381, 151);
            this.txtFinalPercentage2.MaxLength = 6;
            this.txtFinalPercentage2.Multiline = true;
            this.txtFinalPercentage2.Name = "txtFinalPercentage2";
            this.txtFinalPercentage2.PasswordChar = '\0';
            this.txtFinalPercentage2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinalPercentage2.SelectedText = "";
            this.txtFinalPercentage2.SelectionLength = 0;
            this.txtFinalPercentage2.SelectionStart = 0;
            this.txtFinalPercentage2.ShortcutsEnabled = true;
            this.txtFinalPercentage2.Size = new System.Drawing.Size(268, 31);
            this.txtFinalPercentage2.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtFinalPercentage2.TabIndex = 39;
            this.txtFinalPercentage2.UseCustomBackColor = true;
            this.txtFinalPercentage2.UseSelectable = true;
            this.txtFinalPercentage2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinalPercentage2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinalPercentage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // txtFinalPercentage1
            // 
            this.txtFinalPercentage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtFinalPercentage1.CustomButton.Image = null;
            this.txtFinalPercentage1.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtFinalPercentage1.CustomButton.Name = "";
            this.txtFinalPercentage1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtFinalPercentage1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinalPercentage1.CustomButton.TabIndex = 1;
            this.txtFinalPercentage1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinalPercentage1.CustomButton.UseSelectable = true;
            this.txtFinalPercentage1.CustomButton.Visible = false;
            this.txtFinalPercentage1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFinalPercentage1.Lines = new string[0];
            this.txtFinalPercentage1.Location = new System.Drawing.Point(38, 151);
            this.txtFinalPercentage1.MaxLength = 6;
            this.txtFinalPercentage1.Multiline = true;
            this.txtFinalPercentage1.Name = "txtFinalPercentage1";
            this.txtFinalPercentage1.PasswordChar = '\0';
            this.txtFinalPercentage1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinalPercentage1.SelectedText = "";
            this.txtFinalPercentage1.SelectionLength = 0;
            this.txtFinalPercentage1.SelectionStart = 0;
            this.txtFinalPercentage1.ShortcutsEnabled = true;
            this.txtFinalPercentage1.Size = new System.Drawing.Size(268, 31);
            this.txtFinalPercentage1.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtFinalPercentage1.TabIndex = 38;
            this.txtFinalPercentage1.UseCustomBackColor = true;
            this.txtFinalPercentage1.UseSelectable = true;
            this.txtFinalPercentage1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinalPercentage1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinalPercentage1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // txtInterestCSRate
            // 
            this.txtInterestCSRate.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtInterestCSRate.CustomButton.Image = null;
            this.txtInterestCSRate.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtInterestCSRate.CustomButton.Name = "";
            this.txtInterestCSRate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtInterestCSRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterestCSRate.CustomButton.TabIndex = 1;
            this.txtInterestCSRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInterestCSRate.CustomButton.UseSelectable = true;
            this.txtInterestCSRate.CustomButton.Visible = false;
            this.txtInterestCSRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInterestCSRate.Lines = new string[0];
            this.txtInterestCSRate.Location = new System.Drawing.Point(381, 77);
            this.txtInterestCSRate.MaxLength = 10;
            this.txtInterestCSRate.Multiline = true;
            this.txtInterestCSRate.Name = "txtInterestCSRate";
            this.txtInterestCSRate.PasswordChar = '\0';
            this.txtInterestCSRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterestCSRate.SelectedText = "";
            this.txtInterestCSRate.SelectionLength = 0;
            this.txtInterestCSRate.SelectionStart = 0;
            this.txtInterestCSRate.ShortcutsEnabled = true;
            this.txtInterestCSRate.Size = new System.Drawing.Size(268, 31);
            this.txtInterestCSRate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInterestCSRate.TabIndex = 37;
            this.txtInterestCSRate.UseCustomBackColor = true;
            this.txtInterestCSRate.UseSelectable = true;
            this.txtInterestCSRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterestCSRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInterestCSRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // txtDvidendRate
            // 
            this.txtDvidendRate.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtDvidendRate.CustomButton.Image = null;
            this.txtDvidendRate.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtDvidendRate.CustomButton.Name = "";
            this.txtDvidendRate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtDvidendRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDvidendRate.CustomButton.TabIndex = 1;
            this.txtDvidendRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDvidendRate.CustomButton.UseSelectable = true;
            this.txtDvidendRate.CustomButton.Visible = false;
            this.txtDvidendRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDvidendRate.Lines = new string[0];
            this.txtDvidendRate.Location = new System.Drawing.Point(38, 77);
            this.txtDvidendRate.MaxLength = 10;
            this.txtDvidendRate.Multiline = true;
            this.txtDvidendRate.Name = "txtDvidendRate";
            this.txtDvidendRate.PasswordChar = '\0';
            this.txtDvidendRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDvidendRate.SelectedText = "";
            this.txtDvidendRate.SelectionLength = 0;
            this.txtDvidendRate.SelectionStart = 0;
            this.txtDvidendRate.ShortcutsEnabled = true;
            this.txtDvidendRate.Size = new System.Drawing.Size(268, 31);
            this.txtDvidendRate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDvidendRate.TabIndex = 36;
            this.txtDvidendRate.UseCustomBackColor = true;
            this.txtDvidendRate.UseSelectable = true;
            this.txtDvidendRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDvidendRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDvidendRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel8.Location = new System.Drawing.Point(379, 124);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(189, 17);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Final Report Percentage 2 ( % )";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel9.Location = new System.Drawing.Point(35, 126);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(189, 17);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Final Report Percentage 1 ( % )";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel5.Location = new System.Drawing.Point(381, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(239, 17);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Interest on Capital Share Rate (Decimal)";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel6.Location = new System.Drawing.Point(35, 52);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(219, 17);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Dividend Patronage Rate ( Decimal )";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel7.Location = new System.Drawing.Point(16, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 20);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Reports";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.btnBrowseCertificates);
            this.groupBox3.Controls.Add(this.txtSaveCertificates);
            this.groupBox3.Controls.Add(this.txtSaveReports);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.metroLabel14);
            this.groupBox3.Location = new System.Drawing.Point(33, 486);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 213);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(149, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 20);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "( Available Soon )";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnBrowseCertificates
            // 
            this.btnBrowseCertificates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnBrowseCertificates.FlatAppearance.BorderSize = 0;
            this.btnBrowseCertificates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnBrowseCertificates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnBrowseCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCertificates.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCertificates.ForeColor = System.Drawing.Color.White;
            this.btnBrowseCertificates.Location = new System.Drawing.Point(565, 152);
            this.btnBrowseCertificates.Name = "btnBrowseCertificates";
            this.btnBrowseCertificates.Size = new System.Drawing.Size(90, 31);
            this.btnBrowseCertificates.TabIndex = 40;
            this.btnBrowseCertificates.Text = "Browse";
            this.btnBrowseCertificates.UseVisualStyleBackColor = false;
            // 
            // txtSaveCertificates
            // 
            this.txtSaveCertificates.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtSaveCertificates.CustomButton.Image = null;
            this.txtSaveCertificates.CustomButton.Location = new System.Drawing.Point(472, 1);
            this.txtSaveCertificates.CustomButton.Name = "";
            this.txtSaveCertificates.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSaveCertificates.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaveCertificates.CustomButton.TabIndex = 1;
            this.txtSaveCertificates.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaveCertificates.CustomButton.UseSelectable = true;
            this.txtSaveCertificates.CustomButton.Visible = false;
            this.txtSaveCertificates.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSaveCertificates.Lines = new string[0];
            this.txtSaveCertificates.Location = new System.Drawing.Point(38, 152);
            this.txtSaveCertificates.MaxLength = 32767;
            this.txtSaveCertificates.Multiline = true;
            this.txtSaveCertificates.Name = "txtSaveCertificates";
            this.txtSaveCertificates.PasswordChar = '\0';
            this.txtSaveCertificates.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaveCertificates.SelectedText = "";
            this.txtSaveCertificates.SelectionLength = 0;
            this.txtSaveCertificates.SelectionStart = 0;
            this.txtSaveCertificates.ShortcutsEnabled = true;
            this.txtSaveCertificates.Size = new System.Drawing.Size(502, 31);
            this.txtSaveCertificates.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSaveCertificates.TabIndex = 38;
            this.txtSaveCertificates.UseCustomBackColor = true;
            this.txtSaveCertificates.UseSelectable = true;
            this.txtSaveCertificates.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaveCertificates.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSaveReports
            // 
            this.txtSaveReports.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtSaveReports.CustomButton.Image = null;
            this.txtSaveReports.CustomButton.Location = new System.Drawing.Point(472, 1);
            this.txtSaveReports.CustomButton.Name = "";
            this.txtSaveReports.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSaveReports.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaveReports.CustomButton.TabIndex = 1;
            this.txtSaveReports.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaveReports.CustomButton.UseSelectable = true;
            this.txtSaveReports.CustomButton.Visible = false;
            this.txtSaveReports.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSaveReports.Lines = new string[0];
            this.txtSaveReports.Location = new System.Drawing.Point(38, 78);
            this.txtSaveReports.MaxLength = 32767;
            this.txtSaveReports.Multiline = true;
            this.txtSaveReports.Name = "txtSaveReports";
            this.txtSaveReports.PasswordChar = '\0';
            this.txtSaveReports.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaveReports.SelectedText = "";
            this.txtSaveReports.SelectionLength = 0;
            this.txtSaveReports.SelectionStart = 0;
            this.txtSaveReports.ShortcutsEnabled = true;
            this.txtSaveReports.Size = new System.Drawing.Size(502, 31);
            this.txtSaveReports.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSaveReports.TabIndex = 37;
            this.txtSaveReports.UseCustomBackColor = true;
            this.txtSaveReports.UseSelectable = true;
            this.txtSaveReports.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaveReports.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel11.Location = new System.Drawing.Point(38, 126);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(201, 17);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Certificates Default Save Location";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel13.Location = new System.Drawing.Point(35, 53);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(183, 17);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Reports Default Save Location";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel14.Location = new System.Drawing.Point(16, 17);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(105, 20);
            this.metroLabel14.TabIndex = 0;
            this.metroLabel14.Text = "Save Location";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(33, 723);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 20);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "Backup";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel16.Location = new System.Drawing.Point(35, 28);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(278, 17);
            this.metroLabel16.TabIndex = 0;
            this.metroLabel16.Text = "Create an SQL Backup the entire system\'s data";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBackup);
            this.groupBox4.Controls.Add(this.metroLabel16);
            this.groupBox4.Location = new System.Drawing.Point(33, 751);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(687, 68);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(463, 22);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(192, 31);
            this.btnBackup.TabIndex = 36;
            this.btnBackup.Text = "Backup Data";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseReports
            // 
            this.btnBrowseReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnBrowseReports.FlatAppearance.BorderSize = 0;
            this.btnBrowseReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnBrowseReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnBrowseReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseReports.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseReports.ForeColor = System.Drawing.Color.White;
            this.btnBrowseReports.Location = new System.Drawing.Point(598, 564);
            this.btnBrowseReports.Name = "btnBrowseReports";
            this.btnBrowseReports.Size = new System.Drawing.Size(90, 31);
            this.btnBrowseReports.TabIndex = 39;
            this.btnBrowseReports.Text = "Browse";
            this.btnBrowseReports.UseVisualStyleBackColor = false;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(595, 69);
            this.btnAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(125, 40);
            this.btnAction.TabIndex = 40;
            this.btnAction.Text = "Edit";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblEditStatus
            // 
            this.lblEditStatus.AutoSize = true;
            this.lblEditStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEditStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.lblEditStatus.Location = new System.Drawing.Point(115, 85);
            this.lblEditStatus.Name = "lblEditStatus";
            this.lblEditStatus.Size = new System.Drawing.Size(104, 20);
            this.lblEditStatus.TabIndex = 41;
            this.lblEditStatus.Text = "( Edit Status )";
            this.lblEditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditStatus.UseCustomForeColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(376, 69);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 40);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnReset.Location = new System.Drawing.Point(485, 69);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 40);
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 846);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEditStatus);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnBrowseReports);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDefaults);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDefaults;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label lblPercent1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBackup;
        private MetroFramework.Controls.MetroTextBox txtMemberLoanRate;
        private MetroFramework.Controls.MetroTextBox txtLoanPenalty;
        private MetroFramework.Controls.MetroTextBox txtFinalPercentage2;
        private MetroFramework.Controls.MetroTextBox txtFinalPercentage1;
        private MetroFramework.Controls.MetroTextBox txtInterestCSRate;
        private MetroFramework.Controls.MetroTextBox txtDvidendRate;
        private MetroFramework.Controls.MetroTextBox txtSaveReports;
        private MetroFramework.Controls.MetroTextBox txtSaveCertificates;
        private System.Windows.Forms.Label lblPercent3;
        private System.Windows.Forms.Label lblPercent2;
        private System.Windows.Forms.Button btnBrowseReports;
        private System.Windows.Forms.Button btnBrowseCertificates;
        private System.Windows.Forms.Button btnAction;
        private MetroFramework.Controls.MetroLabel lblEditStatus;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
    }
}