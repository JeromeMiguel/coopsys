namespace coopsys
{
    partial class frmViewMemberShares
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
            this.lblmemname = new MetroFramework.Controls.MetroLabel();
            this.lbltotalshares = new MetroFramework.Controls.MetroLabel();
            this.grdShares = new MetroFramework.Controls.MetroGrid();
            this.cboMonth = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboYear = new MetroFramework.Controls.MetroComboBox();
            this.btnAddShare = new System.Windows.Forms.Button();
            this.contextMenuStripDataRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCapitalShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCapitalShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdShares)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripDataRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmemname.Location = new System.Drawing.Point(24, 86);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(71, 20);
            this.lblmemname.TabIndex = 3;
            this.lblmemname.Text = "full name";
            // 
            // lbltotalshares
            // 
            this.lbltotalshares.AutoSize = true;
            this.lbltotalshares.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltotalshares.Location = new System.Drawing.Point(24, 308);
            this.lbltotalshares.Name = "lbltotalshares";
            this.lbltotalshares.Size = new System.Drawing.Size(54, 20);
            this.lbltotalshares.TabIndex = 4;
            this.lbltotalshares.Text = "shares";
            // 
            // grdShares
            // 
            this.grdShares.AllowUserToAddRows = false;
            this.grdShares.AllowUserToDeleteRows = false;
            this.grdShares.AllowUserToResizeColumns = false;
            this.grdShares.AllowUserToResizeRows = false;
            this.grdShares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdShares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdShares.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdShares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdShares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdShares.ColumnHeadersHeight = 29;
            this.grdShares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdShares.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdShares.EnableHeadersVisualStyles = false;
            this.grdShares.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdShares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdShares.Location = new System.Drawing.Point(24, 350);
            this.grdShares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdShares.MultiSelect = false;
            this.grdShares.Name = "grdShares";
            this.grdShares.ReadOnly = true;
            this.grdShares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShares.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdShares.RowHeadersVisible = false;
            this.grdShares.RowHeadersWidth = 51;
            this.grdShares.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdShares.RowTemplate.Height = 24;
            this.grdShares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdShares.Size = new System.Drawing.Size(677, 395);
            this.grdShares.TabIndex = 16;
            this.grdShares.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdShares_CellMouseClick);
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.ItemHeight = 24;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(21, 54);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(169, 30);
            this.cboMonth.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboMonth.TabIndex = 18;
            this.cboMonth.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cboYear);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(677, 113);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(381, 54);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(149, 36);
            this.btnFilter.TabIndex = 23;
            this.btnFilter.Text = "Filter Results";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(315, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 20);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Year";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(121, 30);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 20);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Month";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(555, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 36);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 24;
            this.cboYear.Location = new System.Drawing.Point(209, 54);
            this.cboYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(145, 30);
            this.cboYear.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboYear.TabIndex = 19;
            this.cboYear.UseSelectable = true;
            // 
            // btnAddShare
            // 
            this.btnAddShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnAddShare.FlatAppearance.BorderSize = 0;
            this.btnAddShare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnAddShare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnAddShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShare.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShare.ForeColor = System.Drawing.Color.White;
            this.btnAddShare.Location = new System.Drawing.Point(24, 751);
            this.btnAddShare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddShare.Name = "btnAddShare";
            this.btnAddShare.Size = new System.Drawing.Size(127, 46);
            this.btnAddShare.TabIndex = 22;
            this.btnAddShare.Text = "Add share";
            this.btnAddShare.UseVisualStyleBackColor = false;
            this.btnAddShare.Click += new System.EventHandler(this.btnAddShare_Click);
            // 
            // contextMenuStripDataRow
            // 
            this.contextMenuStripDataRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCapitalShareToolStripMenuItem,
            this.deleteCapitalShareToolStripMenuItem});
            this.contextMenuStripDataRow.Name = "contextMenuStripDataRow";
            this.contextMenuStripDataRow.Size = new System.Drawing.Size(211, 52);
            // 
            // editCapitalShareToolStripMenuItem
            // 
            this.editCapitalShareToolStripMenuItem.Name = "editCapitalShareToolStripMenuItem";
            this.editCapitalShareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editCapitalShareToolStripMenuItem.Text = "Edit capital share";
            this.editCapitalShareToolStripMenuItem.Click += new System.EventHandler(this.editCapitalShareToolStripMenuItem_Click);
            // 
            // deleteCapitalShareToolStripMenuItem
            // 
            this.deleteCapitalShareToolStripMenuItem.Name = "deleteCapitalShareToolStripMenuItem";
            this.deleteCapitalShareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteCapitalShareToolStripMenuItem.Text = "Delete capital share";
            this.deleteCapitalShareToolStripMenuItem.Click += new System.EventHandler(this.deleteCapitalShareToolStripMenuItem_Click);
            // 
            // frmViewMemberShares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 820);
            this.Controls.Add(this.btnAddShare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdShares);
            this.Controls.Add(this.lbltotalshares);
            this.Controls.Add(this.lblmemname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewMemberShares";
            this.Padding = new System.Windows.Forms.Padding(21, 74, 21, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Member Shares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewMemberShares_FormClosed);
            this.Load += new System.EventHandler(this.frmViewMemberShares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShares)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripDataRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblmemname;
        private MetroFramework.Controls.MetroLabel lbltotalshares;
        private MetroFramework.Controls.MetroGrid grdShares;
        private MetroFramework.Controls.MetroComboBox cboMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboYear;
        private System.Windows.Forms.Button btnReset;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnAddShare;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataRow;
        private System.Windows.Forms.ToolStripMenuItem editCapitalShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCapitalShareToolStripMenuItem;
    }
}