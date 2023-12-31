﻿namespace coopsys
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.grdMembers = new MetroFramework.Controls.MetroGrid();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.btnReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiReportsMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportsDividentPatronage = new System.Windows.Forms.ToolStripMenuItem();
            this.report3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.btnPatronage = new System.Windows.Forms.ToolStripButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.tipTools = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearchMem = new System.Windows.Forms.PictureBox();
            this.lblTotalResult = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStripDataRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.capitalShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSharesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboMemType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnDue = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMem)).BeginInit();
            this.contextMenuStripDataRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(789, 231);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search a member...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(345, 33);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search a member...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.AllowUserToResizeColumns = false;
            this.grdMembers.AllowUserToResizeRows = false;
            this.grdMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMembers.ColumnHeadersHeight = 29;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMembers.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdMembers.EnableHeadersVisualStyles = false;
            this.grdMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMembers.Location = new System.Drawing.Point(20, 278);
            this.grdMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMembers.MultiSelect = false;
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMembers.RowHeadersVisible = false;
            this.grdMembers.RowHeadersWidth = 51;
            this.grdMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMembers.RowTemplate.Height = 24;
            this.grdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMembers.Size = new System.Drawing.Size(1159, 443);
            this.grdMembers.TabIndex = 2;
            this.grdMembers.DataSourceChanged += new System.EventHandler(this.grdMembers_DataSourceChanged);
            this.grdMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellDoubleClick);
            this.grdMembers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMembers_CellMouseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.toolStripSeparator1,
            this.btnReports,
            this.toolStripSeparator2,
            this.lblDate,
            this.toolStripSeparator3,
            this.lblTime,
            this.btnPatronage});
            this.toolStrip1.Location = new System.Drawing.Point(20, 74);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 20, 1, 20);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1161, 67);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 24);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReportsMembers,
            this.tsmiReportsDividentPatronage,
            this.report3ToolStripMenuItem,
            this.report4ToolStripMenuItem});
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(74, 24);
            this.btnReports.Text = "Reports";
            // 
            // tsmiReportsMembers
            // 
            this.tsmiReportsMembers.Name = "tsmiReportsMembers";
            this.tsmiReportsMembers.Size = new System.Drawing.Size(224, 26);
            this.tsmiReportsMembers.Text = "Members";
            this.tsmiReportsMembers.Click += new System.EventHandler(this.tsmiReportsMembers_Click);
            // 
            // tsmiReportsDividentPatronage
            // 
            this.tsmiReportsDividentPatronage.Name = "tsmiReportsDividentPatronage";
            this.tsmiReportsDividentPatronage.Size = new System.Drawing.Size(224, 26);
            this.tsmiReportsDividentPatronage.Text = "Divident Patronage";
            this.tsmiReportsDividentPatronage.Click += new System.EventHandler(this.tsmiReportsDividentPatronage_Click);
            // 
            // report3ToolStripMenuItem
            // 
            this.report3ToolStripMenuItem.Name = "report3ToolStripMenuItem";
            this.report3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.report3ToolStripMenuItem.Text = "Report 3";
            // 
            // report4ToolStripMenuItem
            // 
            this.report4ToolStripMenuItem.Name = "report4ToolStripMenuItem";
            this.report4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.report4ToolStripMenuItem.Text = "Report 4";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 24);
            this.lblDate.Text = "date";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 24);
            this.lblTime.Text = "time";
            // 
            // btnPatronage
            // 
            this.btnPatronage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPatronage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPatronage.Image = ((System.Drawing.Image)(resources.GetObject("btnPatronage.Image")));
            this.btnPatronage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatronage.Name = "btnPatronage";
            this.btnPatronage.Size = new System.Drawing.Size(116, 24);
            this.btnPatronage.Text = "Patronage Fund";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // tipTools
            // 
            this.tipTools.IsBalloon = true;
            // 
            // btnSearchMem
            // 
            this.btnSearchMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMem.Image")));
            this.btnSearchMem.Location = new System.Drawing.Point(1141, 231);
            this.btnSearchMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMem.Name = "btnSearchMem";
            this.btnSearchMem.Size = new System.Drawing.Size(36, 33);
            this.btnSearchMem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchMem.TabIndex = 16;
            this.btnSearchMem.TabStop = false;
            this.tipTools.SetToolTip(this.btnSearchMem, "Search");
            this.btnSearchMem.Click += new System.EventHandler(this.btnSearchMem_Click);
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Location = new System.Drawing.Point(20, 241);
            this.lblTotalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(84, 20);
            this.lblTotalResult.TabIndex = 21;
            this.lblTotalResult.Text = "Total Results";
            // 
            // contextMenuStripDataRow
            // 
            this.contextMenuStripDataRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitalShareToolStripMenuItem,
            this.chaToolStripMenuItem});
            this.contextMenuStripDataRow.Name = "contextMenuStripDataRow";
            this.contextMenuStripDataRow.Size = new System.Drawing.Size(231, 52);
            // 
            // capitalShareToolStripMenuItem
            // 
            this.capitalShareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSharesToolStripMenuItem,
            this.printCertificateToolStripMenuItem});
            this.capitalShareToolStripMenuItem.Name = "capitalShareToolStripMenuItem";
            this.capitalShareToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.capitalShareToolStripMenuItem.Text = "Capital Share";
            // 
            // viewSharesToolStripMenuItem
            // 
            this.viewSharesToolStripMenuItem.Name = "viewSharesToolStripMenuItem";
            this.viewSharesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.viewSharesToolStripMenuItem.Text = "View shares";
            this.viewSharesToolStripMenuItem.Click += new System.EventHandler(this.viewSharesToolStripMenuItem_Click);
            // 
            // printCertificateToolStripMenuItem
            // 
            this.printCertificateToolStripMenuItem.Name = "printCertificateToolStripMenuItem";
            this.printCertificateToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.printCertificateToolStripMenuItem.Text = "Print certificate";
            // 
            // chaToolStripMenuItem
            // 
            this.chaToolStripMenuItem.Name = "chaToolStripMenuItem";
            this.chaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.chaToolStripMenuItem.Text = "Change member status";
            // 
            // cboMemType
            // 
            this.cboMemType.FormattingEnabled = true;
            this.cboMemType.ItemHeight = 24;
            this.cboMemType.Items.AddRange(new object[] {
            "All members",
            "Associate",
            "Regular"});
            this.cboMemType.Location = new System.Drawing.Point(997, 732);
            this.cboMemType.Margin = new System.Windows.Forms.Padding(4);
            this.cboMemType.Name = "cboMemType";
            this.cboMemType.Size = new System.Drawing.Size(179, 30);
            this.cboMemType.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboMemType.TabIndex = 7;
            this.cboMemType.UseSelectable = true;
            this.cboMemType.SelectedIndexChanged += new System.EventHandler(this.cboMemType_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(869, 737);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 20);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Member Type:";
            // 
            // btnDue
            // 
            this.btnDue.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDue.Image = global::coopsys.Properties.Resources.due;
            this.btnDue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDue.Location = new System.Drawing.Point(211, 155);
            this.btnDue.Margin = new System.Windows.Forms.Padding(4);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(197, 31);
            this.btnDue.TabIndex = 4;
            this.btnDue.Text = "Due for Payment";
            this.btnDue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDue.UseVisualStyleBackColor = true;
            this.btnDue.Click += new System.EventHandler(this.btnDue_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(953, 155);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Enabled = false;
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(20, 155);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(183, 31);
            this.btnLoan.TabIndex = 3;
            this.btnLoan.Text = "Loans and Payment";
            this.btnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(1037, 155);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(144, 31);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 785);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cboMemType);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.btnSearchMem);
            this.Controls.Add(this.grdMembers);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "MT Multi-Purpose Cooperative";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMem)).EndInit();
            this.contextMenuStripDataRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroGrid grdMembers;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportsMembers;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportsDividentPatronage;
        private System.Windows.Forms.ToolStripMenuItem report3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox btnSearchMem;
        private System.Windows.Forms.ToolTip tipTools;
        private MetroFramework.Controls.MetroLabel lblTotalResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataRow;
        private System.Windows.Forms.ToolStripMenuItem capitalShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSharesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaToolStripMenuItem;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnEdit;
        private MetroFramework.Controls.MetroComboBox cboMemType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnDue;
        private System.Windows.Forms.ToolStripButton btnPatronage;
        private System.Windows.Forms.Button btnAddMember;
    }
}