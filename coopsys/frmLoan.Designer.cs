﻿namespace coopsys
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
            this.txtDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLoanable = new MetroFramework.Controls.MetroTextBox();
            this.txtFee = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.grdLoans = new MetroFramework.Controls.MetroGrid();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblmemname = new MetroFramework.Controls.MetroLabel();
            this.txtTerm = new MetroFramework.Controls.MetroTextBox();
            this.cboLoans = new MetroFramework.Controls.MetroComboBox();
            this.contextMenuStripDataRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enterLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLoanRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInsurance = new MetroFramework.Controls.MetroTextBox();
            this.txtCapitalShare = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).BeginInit();
            this.contextMenuStripDataRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(23, 141);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(135, 30);
            this.txtDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDate.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Date";
            // 
            // txtLoanable
            // 
            // 
            // 
            // 
            this.txtLoanable.CustomButton.Image = null;
            this.txtLoanable.CustomButton.Location = new System.Drawing.Point(252, 1);
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
            this.txtLoanable.Location = new System.Drawing.Point(23, 347);
            this.txtLoanable.MaxLength = 32767;
            this.txtLoanable.Name = "txtLoanable";
            this.txtLoanable.PasswordChar = '\0';
            this.txtLoanable.PromptText = "Loanable Amount";
            this.txtLoanable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoanable.SelectedText = "";
            this.txtLoanable.SelectionLength = 0;
            this.txtLoanable.SelectionStart = 0;
            this.txtLoanable.ShortcutsEnabled = true;
            this.txtLoanable.Size = new System.Drawing.Size(278, 27);
            this.txtLoanable.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtLoanable.TabIndex = 9;
            this.txtLoanable.UseSelectable = true;
            this.txtLoanable.WaterMark = "Loanable Amount";
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
            this.txtFee.Location = new System.Drawing.Point(23, 252);
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
            this.txtAmount.Location = new System.Drawing.Point(23, 203);
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
            // grdLoans
            // 
            this.grdLoans.AllowUserToAddRows = false;
            this.grdLoans.AllowUserToDeleteRows = false;
            this.grdLoans.AllowUserToResizeColumns = false;
            this.grdLoans.AllowUserToResizeRows = false;
            this.grdLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLoans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLoans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdLoans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdLoans.ColumnHeadersHeight = 29;
            this.grdLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLoans.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdLoans.EnableHeadersVisualStyles = false;
            this.grdLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdLoans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLoans.Location = new System.Drawing.Point(322, 69);
            this.grdLoans.Margin = new System.Windows.Forms.Padding(2);
            this.grdLoans.MultiSelect = false;
            this.grdLoans.Name = "grdLoans";
            this.grdLoans.ReadOnly = true;
            this.grdLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdLoans.RowHeadersVisible = false;
            this.grdLoans.RowHeadersWidth = 51;
            this.grdLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLoans.RowTemplate.Height = 24;
            this.grdLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLoans.Size = new System.Drawing.Size(753, 305);
            this.grdLoans.TabIndex = 12;
            this.grdLoans.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdLoans_CellMouseClick);
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
            this.btnCancel.Location = new System.Drawing.Point(166, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(23, 392);
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
            this.txtTerm.Location = new System.Drawing.Point(166, 203);
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
            this.cboLoans.Location = new System.Drawing.Point(913, 391);
            this.cboLoans.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoans.Name = "cboLoans";
            this.cboLoans.Size = new System.Drawing.Size(162, 30);
            this.cboLoans.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboLoans.TabIndex = 13;
            this.cboLoans.UseSelectable = true;
            this.cboLoans.SelectedIndexChanged += new System.EventHandler(this.cboLoans_SelectedIndexChanged);
            // 
            // contextMenuStripDataRow
            // 
            this.contextMenuStripDataRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterLoanToolStripMenuItem,
            this.deleteLoanRecordToolStripMenuItem,
            this.penalizeToolStripMenuItem});
            this.contextMenuStripDataRow.Name = "contextMenuStripDataRow";
            this.contextMenuStripDataRow.Size = new System.Drawing.Size(208, 76);
            // 
            // enterLoanToolStripMenuItem
            // 
            this.enterLoanToolStripMenuItem.Name = "enterLoanToolStripMenuItem";
            this.enterLoanToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.enterLoanToolStripMenuItem.Text = "Enter loan payment";
            this.enterLoanToolStripMenuItem.Click += new System.EventHandler(this.enterLoanToolStripMenuItem_Click);
            // 
            // deleteLoanRecordToolStripMenuItem
            // 
            this.deleteLoanRecordToolStripMenuItem.Name = "deleteLoanRecordToolStripMenuItem";
            this.deleteLoanRecordToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.deleteLoanRecordToolStripMenuItem.Text = "Delete loan record";
            this.deleteLoanRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteLoanRecordToolStripMenuItem_Click);
            // 
            // penalizeToolStripMenuItem
            // 
            this.penalizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPenaltyToolStripMenuItem,
            this.payPenaltyToolStripMenuItem,
            this.removePenaltyToolStripMenuItem});
            this.penalizeToolStripMenuItem.Name = "penalizeToolStripMenuItem";
            this.penalizeToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
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
            this.txtInsurance.Location = new System.Drawing.Point(164, 252);
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
            this.txtCapitalShare.Location = new System.Drawing.Point(23, 300);
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
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 438);
            this.Controls.Add(this.txtCapitalShare);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.cboLoans);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblmemname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdLoans);
            this.Controls.Add(this.txtLoanable);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDate);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).EndInit();
            this.contextMenuStripDataRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txtDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLoanable;
        private MetroFramework.Controls.MetroTextBox txtFee;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroGrid grdLoans;
        private System.Windows.Forms.Button btnCancel;
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
    }
}