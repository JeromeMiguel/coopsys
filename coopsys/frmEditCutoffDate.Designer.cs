namespace coopsys
{
    partial class frmEditCutoffDate
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
            this.lblDay = new MetroFramework.Controls.MetroLabel();
            this.txtDay = new MetroFramework.Controls.MetroDateTime();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.lblDay.Location = new System.Drawing.Point(36, 84);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(80, 17);
            this.lblDay.TabIndex = 43;
            this.lblDay.Text = "Cutoff Day 1";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDay
            // 
            this.txtDay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDay.Location = new System.Drawing.Point(39, 108);
            this.txtDay.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(442, 30);
            this.txtDay.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDay.TabIndex = 44;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(252, 215);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 40);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetDate
            // 
            this.btnSetDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnSetDate.FlatAppearance.BorderSize = 0;
            this.btnSetDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnSetDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnSetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDate.ForeColor = System.Drawing.Color.White;
            this.btnSetDate.Location = new System.Drawing.Point(356, 215);
            this.btnSetDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(125, 40);
            this.btnSetDate.TabIndex = 49;
            this.btnSetDate.Text = "Set Date";
            this.btnSetDate.UseVisualStyleBackColor = false;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroLabel1.Location = new System.Drawing.Point(39, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(314, 17);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "ℹ️ Click SET DATE then SAVE in Settings to Edit Date";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // frmEditCutoffDate
            // 
            this.AcceptButton = this.btnSetDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(504, 277);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblDay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCutoffDate";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Edit Cutoff Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDay;
        private MetroFramework.Controls.MetroDateTime txtDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}