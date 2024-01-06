namespace coopsys
{
    partial class frmReportMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportMembers));
            this.grdReportMembers = new MetroFramework.Controls.MetroGrid();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReportMembers
            // 
            this.grdReportMembers.AllowUserToAddRows = false;
            this.grdReportMembers.AllowUserToDeleteRows = false;
            this.grdReportMembers.AllowUserToResizeColumns = false;
            this.grdReportMembers.AllowUserToResizeRows = false;
            this.grdReportMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdReportMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdReportMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReportMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReportMembers.ColumnHeadersHeight = 29;
            this.grdReportMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReportMembers.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReportMembers.EnableHeadersVisualStyles = false;
            this.grdReportMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdReportMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReportMembers.Location = new System.Drawing.Point(33, 82);
            this.grdReportMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdReportMembers.MultiSelect = false;
            this.grdReportMembers.Name = "grdReportMembers";
            this.grdReportMembers.ReadOnly = true;
            this.grdReportMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReportMembers.RowHeadersVisible = false;
            this.grdReportMembers.RowHeadersWidth = 51;
            this.grdReportMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdReportMembers.RowTemplate.Height = 24;
            this.grdReportMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReportMembers.Size = new System.Drawing.Size(1407, 430);
            this.grdReportMembers.TabIndex = 16;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(1234, 528);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(206, 48);
            this.btnExportExcel.TabIndex = 29;
            this.btnExportExcel.Text = "Export To Excel (.xlxs)";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\"xlsx\"";
            this.saveFileDialog1.Filter = "\"excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Excel File ";
            // 
            // frmReportMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1464, 600);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.grdReportMembers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportMembers";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Members Report";
            this.Load += new System.EventHandler(this.frmReportMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdReportMembers;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}