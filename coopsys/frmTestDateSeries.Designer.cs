namespace coopsys
{
    partial class frmTestDateSeries
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
            this.txtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.btnGetEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartDate
            // 
            this.txtStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Location = new System.Drawing.Point(32, 35);
            this.txtStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(135, 30);
            this.txtStartDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtStartDate.TabIndex = 2;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(32, 89);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(135, 22);
            this.txtDays.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 349);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(32, 319);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(135, 23);
            this.btnGetDates.TabIndex = 5;
            this.btnGetDates.Text = "Get Dates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(32, 274);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(135, 24);
            this.cboPaymentMethod.TabIndex = 6;
            // 
            // txtEndDate
            // 
            this.txtEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Location = new System.Drawing.Point(32, 170);
            this.txtEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(135, 30);
            this.txtEndDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtEndDate.TabIndex = 7;
            // 
            // btnGetEnd
            // 
            this.btnGetEnd.Location = new System.Drawing.Point(32, 141);
            this.btnGetEnd.Name = "btnGetEnd";
            this.btnGetEnd.Size = new System.Drawing.Size(135, 23);
            this.btnGetEnd.TabIndex = 8;
            this.btnGetEnd.Text = "Get End Date";
            this.btnGetEnd.UseVisualStyleBackColor = true;
            this.btnGetEnd.Click += new System.EventHandler(this.btnGetEnd_Click);
            // 
            // frmTestDateSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetEnd);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.cboPaymentMethod);
            this.Controls.Add(this.btnGetDates);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtStartDate);
            this.Name = "frmTestDateSeries";
            this.Text = "frmTestDateSeries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime txtStartDate;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private MetroFramework.Controls.MetroDateTime txtEndDate;
        private System.Windows.Forms.Button btnGetEnd;
    }
}