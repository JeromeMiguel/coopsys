namespace coopsys
{
    partial class frmLoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLoanable = new MetroFramework.Controls.MetroTextBox();
            this.txtFee = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblmemname = new MetroFramework.Controls.MetroLabel();
            this.txtTerm = new MetroFramework.Controls.MetroTextBox();
            this.cboLoans = new MetroFramework.Controls.MetroComboBox();
            this.contextMenuStripDataRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enterLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLoanRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditCollateralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInsurance = new MetroFramework.Controls.MetroTextBox();
            this.txtCapitalShare = new MetroFramework.Controls.MetroTextBox();
            this.grdPayment = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterest = new MetroFramework.Controls.MetroTextBox();
            this.grdLoans = new MetroFramework.Controls.MetroGrid();
            this.cboFillTable = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.txtAddFee2 = new MetroFramework.Controls.MetroTextBox();
            this.txtAddFee1 = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCollateral = new System.Windows.Forms.LinkLabel();
            this.lblLoanType = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStripDataRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(23, 131);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(135, 30);
            this.txtDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDate.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Date";
            // 
            // txtLoanable
            // 
            this.txtLoanable.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtLoanable.CustomButton.Image = null;
            this.txtLoanable.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtLoanable.CustomButton.Name = "";
            this.txtLoanable.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtLoanable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoanable.CustomButton.TabIndex = 1;
            this.txtLoanable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoanable.CustomButton.UseSelectable = true;
            this.txtLoanable.CustomButton.Visible = false;
            this.txtLoanable.Enabled = false;
            this.txtLoanable.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLoanable.Lines = new string[0];
            this.txtLoanable.Location = new System.Drawing.Point(23, 322);
            this.txtLoanable.MaxLength = 32767;
            this.txtLoanable.Name = "txtLoanable";
            this.txtLoanable.PasswordChar = '\0';
            this.txtLoanable.PromptText = "Net Proceeds";
            this.txtLoanable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoanable.SelectedText = "";
            this.txtLoanable.SelectionLength = 0;
            this.txtLoanable.SelectionStart = 0;
            this.txtLoanable.ShortcutsEnabled = true;
            this.txtLoanable.Size = new System.Drawing.Size(276, 27);
            this.txtLoanable.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtLoanable.TabIndex = 9;
            this.txtLoanable.UseCustomBackColor = true;
            this.txtLoanable.UseSelectable = true;
            this.txtLoanable.WaterMark = "Net Proceeds";
            this.txtLoanable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoanable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFee
            // 
            // 
            // 
            // 
            this.txtFee.CustomButton.Image = null;
            this.txtFee.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtFee.CustomButton.Name = "";
            this.txtFee.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFee.CustomButton.TabIndex = 1;
            this.txtFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFee.CustomButton.UseSelectable = true;
            this.txtFee.CustomButton.Visible = false;
            this.txtFee.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFee.Lines = new string[0];
            this.txtFee.Location = new System.Drawing.Point(23, 227);
            this.txtFee.MaxLength = 32767;
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.PromptText = "Loan Fee";
            this.txtFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFee.SelectedText = "";
            this.txtFee.SelectionLength = 0;
            this.txtFee.SelectionStart = 0;
            this.txtFee.ShortcutsEnabled = true;
            this.txtFee.Size = new System.Drawing.Size(135, 27);
            this.txtFee.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtFee.TabIndex = 6;
            this.txtFee.UseSelectable = true;
            this.txtFee.WaterMark = "Loan Fee";
            this.txtFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(23, 178);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "Amount";
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(135, 27);
            this.txtAmount.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtAmount.TabIndex = 4;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "Amount";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(166, 707);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(23, 707);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmemname.Location = new System.Drawing.Point(23, 69);
            this.lblmemname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(71, 20);
            this.lblmemname.TabIndex = 21;
            this.lblmemname.Text = "full name";
            // 
            // txtTerm
            // 
            // 
            // 
            // 
            this.txtTerm.CustomButton.Image = null;
            this.txtTerm.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtTerm.CustomButton.Name = "";
            this.txtTerm.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTerm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTerm.CustomButton.TabIndex = 1;
            this.txtTerm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTerm.CustomButton.UseSelectable = true;
            this.txtTerm.CustomButton.Visible = false;
            this.txtTerm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTerm.Lines = new string[0];
            this.txtTerm.Location = new System.Drawing.Point(166, 178);
            this.txtTerm.MaxLength = 32767;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.PasswordChar = '\0';
            this.txtTerm.PromptText = "Term (days)";
            this.txtTerm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTerm.SelectedText = "";
            this.txtTerm.SelectionLength = 0;
            this.txtTerm.SelectionStart = 0;
            this.txtTerm.ShortcutsEnabled = true;
            this.txtTerm.Size = new System.Drawing.Size(135, 27);
            this.txtTerm.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtTerm.TabIndex = 5;
            this.txtTerm.UseSelectable = true;
            this.txtTerm.WaterMark = "Term (days)";
            this.txtTerm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTerm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerm_KeyPress);
            // 
            // cboLoans
            // 
            this.cboLoans.FormattingEnabled = true;
            this.cboLoans.ItemHeight = 24;
            this.cboLoans.Items.AddRange(new object[] {
            "All loans",
            "Active loans",
            "Paid loans"});
            this.cboLoans.Location = new System.Drawing.Point(896, 709);
            this.cboLoans.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoans.Name = "cboLoans";
            this.cboLoans.Size = new System.Drawing.Size(162, 30);
            this.cboLoans.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboLoans.TabIndex = 13;
            this.cboLoans.UseSelectable = true;
            this.cboLoans.SelectedIndexChanged += new System.EventHandler(this.cboLoans_SelectedIndexChanged);
            this.cboLoans.TextChanged += new System.EventHandler(this.cboLoans_TextChanged);
            // 
            // contextMenuStripDataRow
            // 
            this.contextMenuStripDataRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterLoanToolStripMenuItem,
            this.deleteLoanRecordToolStripMenuItem,
            this.viewEditCollateralToolStripMenuItem,
            this.penalizeToolStripMenuItem});
            this.contextMenuStripDataRow.Name = "contextMenuStripDataRow";
            this.contextMenuStripDataRow.Size = new System.Drawing.Size(211, 100);
            // 
            // enterLoanToolStripMenuItem
            // 
            this.enterLoanToolStripMenuItem.Name = "enterLoanToolStripMenuItem";
            this.enterLoanToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.enterLoanToolStripMenuItem.Text = "Enter loan payment";
            this.enterLoanToolStripMenuItem.Click += new System.EventHandler(this.enterLoanToolStripMenuItem_Click);
            // 
            // deleteLoanRecordToolStripMenuItem
            // 
            this.deleteLoanRecordToolStripMenuItem.Name = "deleteLoanRecordToolStripMenuItem";
            this.deleteLoanRecordToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteLoanRecordToolStripMenuItem.Text = "Delete loan record";
            this.deleteLoanRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteLoanRecordToolStripMenuItem_Click);
            // 
            // viewEditCollateralToolStripMenuItem
            // 
            this.viewEditCollateralToolStripMenuItem.Name = "viewEditCollateralToolStripMenuItem";
            this.viewEditCollateralToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.viewEditCollateralToolStripMenuItem.Text = "View/Edit Collateral";
            this.viewEditCollateralToolStripMenuItem.Click += new System.EventHandler(this.viewEditCollateralToolStripMenuItem_Click);
            // 
            // penalizeToolStripMenuItem
            // 
            this.penalizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPenaltyToolStripMenuItem,
            this.payPenaltyToolStripMenuItem,
            this.removePenaltyToolStripMenuItem});
            this.penalizeToolStripMenuItem.Name = "penalizeToolStripMenuItem";
            this.penalizeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.penalizeToolStripMenuItem.Text = "Penalty";
            // 
            // setPenaltyToolStripMenuItem
            // 
            this.setPenaltyToolStripMenuItem.Name = "setPenaltyToolStripMenuItem";
            this.setPenaltyToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.setPenaltyToolStripMenuItem.Text = "Set penalty";
            this.setPenaltyToolStripMenuItem.Click += new System.EventHandler(this.setPenaltyToolStripMenuItem_Click);
            // 
            // payPenaltyToolStripMenuItem
            // 
            this.payPenaltyToolStripMenuItem.Name = "payPenaltyToolStripMenuItem";
            this.payPenaltyToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.payPenaltyToolStripMenuItem.Text = "Settle penalty";
            this.payPenaltyToolStripMenuItem.Visible = false;
            // 
            // removePenaltyToolStripMenuItem
            // 
            this.removePenaltyToolStripMenuItem.Name = "removePenaltyToolStripMenuItem";
            this.removePenaltyToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.removePenaltyToolStripMenuItem.Text = "Remove penalty";
            this.removePenaltyToolStripMenuItem.Click += new System.EventHandler(this.removePenaltyToolStripMenuItem_Click);
            // 
            // txtInsurance
            // 
            // 
            // 
            // 
            this.txtInsurance.CustomButton.Image = null;
            this.txtInsurance.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtInsurance.CustomButton.Name = "";
            this.txtInsurance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInsurance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInsurance.CustomButton.TabIndex = 1;
            this.txtInsurance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInsurance.CustomButton.UseSelectable = true;
            this.txtInsurance.CustomButton.Visible = false;
            this.txtInsurance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInsurance.Lines = new string[0];
            this.txtInsurance.Location = new System.Drawing.Point(164, 227);
            this.txtInsurance.MaxLength = 32767;
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.PasswordChar = '\0';
            this.txtInsurance.PromptText = "Insurance";
            this.txtInsurance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInsurance.SelectedText = "";
            this.txtInsurance.SelectionLength = 0;
            this.txtInsurance.SelectionStart = 0;
            this.txtInsurance.ShortcutsEnabled = true;
            this.txtInsurance.Size = new System.Drawing.Size(135, 27);
            this.txtInsurance.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInsurance.TabIndex = 7;
            this.txtInsurance.UseSelectable = true;
            this.txtInsurance.WaterMark = "Insurance";
            this.txtInsurance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInsurance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsurance_KeyPress);
            // 
            // txtCapitalShare
            // 
            // 
            // 
            // 
            this.txtCapitalShare.CustomButton.Image = null;
            this.txtCapitalShare.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtCapitalShare.CustomButton.Name = "";
            this.txtCapitalShare.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCapitalShare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCapitalShare.CustomButton.TabIndex = 1;
            this.txtCapitalShare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCapitalShare.CustomButton.UseSelectable = true;
            this.txtCapitalShare.CustomButton.Visible = false;
            this.txtCapitalShare.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCapitalShare.Lines = new string[0];
            this.txtCapitalShare.Location = new System.Drawing.Point(23, 275);
            this.txtCapitalShare.MaxLength = 32767;
            this.txtCapitalShare.Name = "txtCapitalShare";
            this.txtCapitalShare.PasswordChar = '\0';
            this.txtCapitalShare.PromptText = "Capital Share (optional)";
            this.txtCapitalShare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCapitalShare.SelectedText = "";
            this.txtCapitalShare.SelectionLength = 0;
            this.txtCapitalShare.SelectionStart = 0;
            this.txtCapitalShare.ShortcutsEnabled = true;
            this.txtCapitalShare.Size = new System.Drawing.Size(276, 27);
            this.txtCapitalShare.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCapitalShare.TabIndex = 8;
            this.txtCapitalShare.UseSelectable = true;
            this.txtCapitalShare.WaterMark = "Capital Share (optional)";
            this.txtCapitalShare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCapitalShare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCapitalShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapitalShare_KeyPress);
            // 
            // grdPayment
            // 
            this.grdPayment.AllowUserToAddRows = false;
            this.grdPayment.AllowUserToDeleteRows = false;
            this.grdPayment.AllowUserToResizeColumns = false;
            this.grdPayment.AllowUserToResizeRows = false;
            this.grdPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPayment.EnableHeadersVisualStyles = false;
            this.grdPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPayment.Location = new System.Drawing.Point(343, 464);
            this.grdPayment.Margin = new System.Windows.Forms.Padding(2);
            this.grdPayment.MultiSelect = false;
            this.grdPayment.Name = "grdPayment";
            this.grdPayment.ReadOnly = true;
            this.grdPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPayment.RowHeadersWidth = 51;
            this.grdPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPayment.RowTemplate.Height = 24;
            this.grdPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPayment.Size = new System.Drawing.Size(715, 226);
            this.grdPayment.TabIndex = 22;
            this.grdPayment.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPayment_ColumnHeaderMouseClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(343, 42);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 25);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Loans";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(343, 437);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 25);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Payment";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(166, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 20);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Interest Rate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(276, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 24);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInterest
            // 
            // 
            // 
            // 
            this.txtInterest.CustomButton.Image = null;
            this.txtInterest.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtInterest.CustomButton.Name = "";
            this.txtInterest.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInterest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterest.CustomButton.TabIndex = 1;
            this.txtInterest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInterest.CustomButton.UseSelectable = true;
            this.txtInterest.CustomButton.Visible = false;
            this.txtInterest.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInterest.Lines = new string[0];
            this.txtInterest.Location = new System.Drawing.Point(166, 134);
            this.txtInterest.MaxLength = 32767;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.PasswordChar = '\0';
            this.txtInterest.PromptText = "Enter Rate";
            this.txtInterest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterest.SelectedText = "";
            this.txtInterest.SelectionLength = 0;
            this.txtInterest.SelectionStart = 0;
            this.txtInterest.ShortcutsEnabled = true;
            this.txtInterest.Size = new System.Drawing.Size(135, 27);
            this.txtInterest.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInterest.TabIndex = 25;
            this.txtInterest.UseSelectable = true;
            this.txtInterest.WaterMark = "Enter Rate";
            this.txtInterest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // grdLoans
            // 
            this.grdLoans.AllowUserToAddRows = false;
            this.grdLoans.AllowUserToDeleteRows = false;
            this.grdLoans.AllowUserToResizeColumns = false;
            this.grdLoans.AllowUserToResizeRows = false;
            this.grdLoans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLoans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdLoans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLoans.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdLoans.EnableHeadersVisualStyles = false;
            this.grdLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdLoans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLoans.Location = new System.Drawing.Point(343, 71);
            this.grdLoans.Margin = new System.Windows.Forms.Padding(2);
            this.grdLoans.MultiSelect = false;
            this.grdLoans.Name = "grdLoans";
            this.grdLoans.ReadOnly = true;
            this.grdLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdLoans.RowHeadersWidth = 51;
            this.grdLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLoans.RowTemplate.Height = 24;
            this.grdLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLoans.Size = new System.Drawing.Size(715, 349);
            this.grdLoans.TabIndex = 28;
            this.grdLoans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLoans_CellDoubleClick);
            this.grdLoans.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdLoans_CellMouseClick);
            this.grdLoans.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdLoans_ColumnHeaderMouseClick);
            // 
            // cboFillTable
            // 
            this.cboFillTable.AutoSize = true;
            this.cboFillTable.Location = new System.Drawing.Point(911, 45);
            this.cboFillTable.Name = "cboFillTable";
            this.cboFillTable.Size = new System.Drawing.Size(153, 17);
            this.cboFillTable.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboFillTable.TabIndex = 29;
            this.cboFillTable.Text = "Fit all columns in table";
            this.cboFillTable.UseSelectable = true;
            this.cboFillTable.CheckedChanged += new System.EventHandler(this.cboFillTable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.txtAddFee2);
            this.groupBox1.Controls.Add(this.txtAddFee1);
            this.groupBox1.Location = new System.Drawing.Point(23, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 188);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Fees (optional)";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(196, 2);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(6, 112);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PromptText = "Remarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(264, 70);
            this.txtRemarks.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtRemarks.TabIndex = 33;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMark = "Remarks";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddFee2
            // 
            // 
            // 
            // 
            this.txtAddFee2.CustomButton.Image = null;
            this.txtAddFee2.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtAddFee2.CustomButton.Name = "";
            this.txtAddFee2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAddFee2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddFee2.CustomButton.TabIndex = 1;
            this.txtAddFee2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddFee2.CustomButton.UseSelectable = true;
            this.txtAddFee2.CustomButton.Visible = false;
            this.txtAddFee2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddFee2.Lines = new string[0];
            this.txtAddFee2.Location = new System.Drawing.Point(6, 68);
            this.txtAddFee2.MaxLength = 32767;
            this.txtAddFee2.Name = "txtAddFee2";
            this.txtAddFee2.PasswordChar = '\0';
            this.txtAddFee2.PromptText = "Additional Fee 2";
            this.txtAddFee2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddFee2.SelectedText = "";
            this.txtAddFee2.SelectionLength = 0;
            this.txtAddFee2.SelectionStart = 0;
            this.txtAddFee2.ShortcutsEnabled = true;
            this.txtAddFee2.Size = new System.Drawing.Size(264, 27);
            this.txtAddFee2.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtAddFee2.TabIndex = 32;
            this.txtAddFee2.UseSelectable = true;
            this.txtAddFee2.WaterMark = "Additional Fee 2";
            this.txtAddFee2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddFee2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddFee1
            // 
            // 
            // 
            // 
            this.txtAddFee1.CustomButton.Image = null;
            this.txtAddFee1.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtAddFee1.CustomButton.Name = "";
            this.txtAddFee1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAddFee1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddFee1.CustomButton.TabIndex = 1;
            this.txtAddFee1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddFee1.CustomButton.UseSelectable = true;
            this.txtAddFee1.CustomButton.Visible = false;
            this.txtAddFee1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddFee1.Lines = new string[0];
            this.txtAddFee1.Location = new System.Drawing.Point(6, 28);
            this.txtAddFee1.MaxLength = 32767;
            this.txtAddFee1.Name = "txtAddFee1";
            this.txtAddFee1.PasswordChar = '\0';
            this.txtAddFee1.PromptText = "Additional Fee 1";
            this.txtAddFee1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddFee1.SelectedText = "";
            this.txtAddFee1.SelectionLength = 0;
            this.txtAddFee1.SelectionStart = 0;
            this.txtAddFee1.ShortcutsEnabled = true;
            this.txtAddFee1.Size = new System.Drawing.Size(264, 27);
            this.txtAddFee1.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtAddFee1.TabIndex = 31;
            this.txtAddFee1.UseSelectable = true;
            this.txtAddFee1.WaterMark = "Additional Fee 1";
            this.txtAddFee1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddFee1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddCollateral
            // 
            this.btnAddCollateral.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnAddCollateral.AutoSize = true;
            this.btnAddCollateral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCollateral.Location = new System.Drawing.Point(21, 561);
            this.btnAddCollateral.Name = "btnAddCollateral";
            this.btnAddCollateral.Size = new System.Drawing.Size(124, 19);
            this.btnAddCollateral.TabIndex = 31;
            this.btnAddCollateral.TabStop = true;
            this.btnAddCollateral.Text = "Add/Edit Collateral";
            this.btnAddCollateral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAddCollateral_LinkClicked);
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLoanType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.lblLoanType.Location = new System.Drawing.Point(398, 46);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(92, 20);
            this.lblLoanType.TabIndex = 32;
            this.lblLoanType.Text = "(Loan Type)";
            this.lblLoanType.UseCustomForeColor = true;
            // 
            // frmLoan
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 750);
            this.Controls.Add(this.lblLoanType);
            this.Controls.Add(this.btnAddCollateral);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFillTable);
            this.Controls.Add(this.grdLoans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.grdPayment);
            this.Controls.Add(this.txtCapitalShare);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.cboLoans);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblmemname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLoanable);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAmount);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoan";
            this.Padding = new System.Windows.Forms.Padding(20, 69, 20, 23);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Member Loan";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoan_FormClosed);
            this.Load += new System.EventHandler(this.frmLoan_Load);
            this.contextMenuStripDataRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txtDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLoanable;
        private MetroFramework.Controls.MetroTextBox txtFee;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroLabel lblmemname;
        private MetroFramework.Controls.MetroTextBox txtTerm;
        private MetroFramework.Controls.MetroComboBox cboLoans;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataRow;
        private System.Windows.Forms.ToolStripMenuItem enterLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLoanRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPenaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePenaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPenaltyToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtInsurance;
        private MetroFramework.Controls.MetroTextBox txtCapitalShare;
        private MetroFramework.Controls.MetroGrid grdPayment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtInterest;
        public MetroFramework.Controls.MetroGrid grdLoans;
        private MetroFramework.Controls.MetroCheckBox cboFillTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private MetroFramework.Controls.MetroTextBox txtAddFee2;
        private MetroFramework.Controls.MetroTextBox txtAddFee1;
        private System.Windows.Forms.LinkLabel btnAddCollateral;
        private System.Windows.Forms.ToolStripMenuItem viewEditCollateralToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblLoanType;
    }
}