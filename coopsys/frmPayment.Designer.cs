namespace coopsys
{
    partial class frmPayment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblBalance = new MetroFramework.Controls.MetroLabel();
            this.lblDueDate = new MetroFramework.Controls.MetroLabel();
            this.lblPenalty = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroDateTime();
            this.chkCheck = new MetroFramework.Controls.MetroCheckBox();
            this.txtCheckNo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelPenalty = new System.Windows.Forms.Button();
            this.btnPayPenalty = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPenaltyPayment = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(512, 312);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPaymentAmount
            // 
            // 
            // 
            // 
            this.txtPaymentAmount.CustomButton.Image = null;
            this.txtPaymentAmount.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txtPaymentAmount.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.CustomButton.Name = "";
            this.txtPaymentAmount.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtPaymentAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentAmount.CustomButton.TabIndex = 1;
            this.txtPaymentAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentAmount.CustomButton.UseSelectable = true;
            this.txtPaymentAmount.CustomButton.Visible = false;
            this.txtPaymentAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPaymentAmount.Lines = new string[0];
            this.txtPaymentAmount.Location = new System.Drawing.Point(212, 312);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.MaxLength = 32767;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.SelectionLength = 0;
            this.txtPaymentAmount.SelectionStart = 0;
            this.txtPaymentAmount.ShortcutsEnabled = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(292, 33);
            this.txtPaymentAmount.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPaymentAmount.TabIndex = 4;
            this.txtPaymentAmount.UseSelectable = true;
            this.txtPaymentAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentAmount_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 316);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 20);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Payment Amount:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 105);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 20);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Balance:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(312, 105);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 20);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Loan Penalty:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 150);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Due date:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(134, 105);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(27, 20);
            this.lblBalance.TabIndex = 27;
            this.lblBalance.Text = "bal";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(143, 150);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(33, 20);
            this.lblDueDate.TabIndex = 28;
            this.lblDueDate.Text = "due";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(435, 105);
            this.lblPenalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(33, 20);
            this.lblPenalty.TabIndex = 29;
            this.lblPenalty.Text = "pen";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(41, 203);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 20);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Payment Date:";
            // 
            // txtDate
            // 
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(171, 196);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(135, 30);
            this.txtDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDate.TabIndex = 1;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkCheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkCheck.Location = new System.Drawing.Point(41, 263);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(122, 20);
            this.chkCheck.Style = MetroFramework.MetroColorStyle.Purple;
            this.chkCheck.TabIndex = 2;
            this.chkCheck.Text = "Check payment";
            this.chkCheck.UseSelectable = true;
            this.chkCheck.CheckedChanged += new System.EventHandler(this.chkCheck_CheckedChanged);
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txtCheckNo.CustomButton.Image = null;
            this.txtCheckNo.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.txtCheckNo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckNo.CustomButton.Name = "";
            this.txtCheckNo.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCheckNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCheckNo.CustomButton.TabIndex = 1;
            this.txtCheckNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCheckNo.CustomButton.UseSelectable = true;
            this.txtCheckNo.CustomButton.Visible = false;
            this.txtCheckNo.Enabled = false;
            this.txtCheckNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCheckNo.Lines = new string[0];
            this.txtCheckNo.Location = new System.Drawing.Point(212, 257);
            this.txtCheckNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckNo.MaxLength = 32767;
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.PasswordChar = '\0';
            this.txtCheckNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCheckNo.SelectedText = "";
            this.txtCheckNo.SelectionLength = 0;
            this.txtCheckNo.SelectionStart = 0;
            this.txtCheckNo.ShortcutsEnabled = true;
            this.txtCheckNo.Size = new System.Drawing.Size(401, 33);
            this.txtCheckNo.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCheckNo.TabIndex = 3;
            this.txtCheckNo.UseCustomBackColor = true;
            this.txtCheckNo.UseSelectable = true;
            this.txtCheckNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCheckNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelPenalty);
            this.groupBox1.Controls.Add(this.btnPayPenalty);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtPenaltyPayment);
            this.groupBox1.Location = new System.Drawing.Point(23, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 159);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penalty";
            // 
            // btnCancelPenalty
            // 
            this.btnCancelPenalty.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelPenalty.FlatAppearance.BorderSize = 0;
            this.btnCancelPenalty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPenalty.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPenalty.ForeColor = System.Drawing.Color.White;
            this.btnCancelPenalty.Location = new System.Drawing.Point(299, 96);
            this.btnCancelPenalty.Name = "btnCancelPenalty";
            this.btnCancelPenalty.Size = new System.Drawing.Size(146, 33);
            this.btnCancelPenalty.TabIndex = 34;
            this.btnCancelPenalty.Text = "Cancel Penalty";
            this.btnCancelPenalty.UseVisualStyleBackColor = false;
            this.btnCancelPenalty.Click += new System.EventHandler(this.btnCancelPenalty_Click);
            // 
            // btnPayPenalty
            // 
            this.btnPayPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.btnPayPenalty.FlatAppearance.BorderSize = 0;
            this.btnPayPenalty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(199)))));
            this.btnPayPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.btnPayPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayPenalty.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayPenalty.ForeColor = System.Drawing.Color.White;
            this.btnPayPenalty.Location = new System.Drawing.Point(459, 96);
            this.btnPayPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayPenalty.Name = "btnPayPenalty";
            this.btnPayPenalty.Size = new System.Drawing.Size(134, 33);
            this.btnPayPenalty.TabIndex = 33;
            this.btnPayPenalty.Text = "Pay Penalty";
            this.btnPayPenalty.UseVisualStyleBackColor = false;
            this.btnPayPenalty.Click += new System.EventHandler(this.btnPayPenalty_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 50);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 20);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Payment Amount:";
            // 
            // txtPenaltyPayment
            // 
            // 
            // 
            // 
            this.txtPenaltyPayment.CustomButton.Image = null;
            this.txtPenaltyPayment.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.txtPenaltyPayment.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPenaltyPayment.CustomButton.Name = "";
            this.txtPenaltyPayment.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtPenaltyPayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPenaltyPayment.CustomButton.TabIndex = 1;
            this.txtPenaltyPayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPenaltyPayment.CustomButton.UseSelectable = true;
            this.txtPenaltyPayment.CustomButton.Visible = false;
            this.txtPenaltyPayment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPenaltyPayment.Lines = new string[0];
            this.txtPenaltyPayment.Location = new System.Drawing.Point(189, 40);
            this.txtPenaltyPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtPenaltyPayment.MaxLength = 32767;
            this.txtPenaltyPayment.Name = "txtPenaltyPayment";
            this.txtPenaltyPayment.PasswordChar = '\0';
            this.txtPenaltyPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPenaltyPayment.SelectedText = "";
            this.txtPenaltyPayment.SelectionLength = 0;
            this.txtPenaltyPayment.SelectionStart = 0;
            this.txtPenaltyPayment.ShortcutsEnabled = true;
            this.txtPenaltyPayment.Size = new System.Drawing.Size(401, 33);
            this.txtPenaltyPayment.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPenaltyPayment.TabIndex = 4;
            this.txtPenaltyPayment.UseCustomBackColor = true;
            this.txtPenaltyPayment.UseSelectable = true;
            this.txtPenaltyPayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPenaltyPayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCheckNo);
            this.Controls.Add(this.chkCheck);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.metroLabel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Loan Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtPaymentAmount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblBalance;
        private MetroFramework.Controls.MetroLabel lblDueDate;
        private MetroFramework.Controls.MetroLabel lblPenalty;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime txtDate;
        private MetroFramework.Controls.MetroCheckBox chkCheck;
        private MetroFramework.Controls.MetroTextBox txtCheckNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPayPenalty;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPenaltyPayment;
        private System.Windows.Forms.Button btnCancelPenalty;
    }
}