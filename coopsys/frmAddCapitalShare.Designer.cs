namespace coopsys
{
    partial class frmAddCapitalShare
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
            this.txtCapitalShare = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroDateTime();
            this.tipRequired = new System.Windows.Forms.ToolTip(this.components);
            this.chkUnclaimed = new MetroFramework.Controls.MetroCheckBox();
            this.txtOrNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtCapitalShare
            // 
            // 
            // 
            // 
            this.txtCapitalShare.CustomButton.Image = null;
            this.txtCapitalShare.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txtCapitalShare.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapitalShare.CustomButton.Name = "";
            this.txtCapitalShare.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCapitalShare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCapitalShare.CustomButton.TabIndex = 1;
            this.txtCapitalShare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCapitalShare.CustomButton.UseSelectable = true;
            this.txtCapitalShare.CustomButton.Visible = false;
            this.txtCapitalShare.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCapitalShare.Lines = new string[0];
            this.txtCapitalShare.Location = new System.Drawing.Point(152, 208);
            this.txtCapitalShare.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapitalShare.MaxLength = 32767;
            this.txtCapitalShare.Name = "txtCapitalShare";
            this.txtCapitalShare.PasswordChar = '\0';
            this.txtCapitalShare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCapitalShare.SelectedText = "";
            this.txtCapitalShare.SelectionLength = 0;
            this.txtCapitalShare.SelectionStart = 0;
            this.txtCapitalShare.ShortcutsEnabled = true;
            this.txtCapitalShare.Size = new System.Drawing.Size(292, 33);
            this.txtCapitalShare.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCapitalShare.TabIndex = 2;
            this.txtCapitalShare.UseSelectable = true;
            this.txtCapitalShare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCapitalShare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCapitalShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapitalShare_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(57, 208);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Amount:";
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
            this.btnSave.Location = new System.Drawing.Point(452, 208);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.tipRequired.SetToolTip(this.btnSave, "Please enter the capital share amount.");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 116);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 20);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(153, 113);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 30);
            this.txtDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtDate.TabIndex = 1;
            // 
            // tipRequired
            // 
            this.tipRequired.IsBalloon = true;
            this.tipRequired.ShowAlways = true;
            this.tipRequired.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipRequired.ToolTipTitle = "Required Field";
            // 
            // chkUnclaimed
            // 
            this.chkUnclaimed.AutoSize = true;
            this.chkUnclaimed.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkUnclaimed.Location = new System.Drawing.Point(152, 266);
            this.chkUnclaimed.Name = "chkUnclaimed";
            this.chkUnclaimed.Size = new System.Drawing.Size(96, 20);
            this.chkUnclaimed.Style = MetroFramework.MetroColorStyle.Purple;
            this.chkUnclaimed.TabIndex = 19;
            this.chkUnclaimed.Text = "Unclaimed";
            this.chkUnclaimed.UseSelectable = true;
            // 
            // txtOrNum
            // 
            // 
            // 
            // 
            this.txtOrNum.CustomButton.Image = null;
            this.txtOrNum.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txtOrNum.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrNum.CustomButton.Name = "";
            this.txtOrNum.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtOrNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrNum.CustomButton.TabIndex = 1;
            this.txtOrNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrNum.CustomButton.UseSelectable = true;
            this.txtOrNum.CustomButton.Visible = false;
            this.txtOrNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOrNum.Lines = new string[0];
            this.txtOrNum.Location = new System.Drawing.Point(153, 162);
            this.txtOrNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrNum.MaxLength = 32767;
            this.txtOrNum.Name = "txtOrNum";
            this.txtOrNum.PasswordChar = '\0';
            this.txtOrNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrNum.SelectedText = "";
            this.txtOrNum.SelectionLength = 0;
            this.txtOrNum.SelectionStart = 0;
            this.txtOrNum.ShortcutsEnabled = true;
            this.txtOrNum.Size = new System.Drawing.Size(292, 33);
            this.txtOrNum.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtOrNum.TabIndex = 20;
            this.txtOrNum.UseSelectable = true;
            this.txtOrNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 162);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 20);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "OR Number:";
            // 
            // frmAddCapitalShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 316);
            this.Controls.Add(this.txtOrNum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.chkUnclaimed);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCapitalShare);
            this.Controls.Add(this.metroLabel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAddCapitalShare";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Capital Share";
            this.Load += new System.EventHandler(this.frmAddCapitalShare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCapitalShare;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime txtDate;
        private System.Windows.Forms.ToolTip tipRequired;
        private MetroFramework.Controls.MetroCheckBox chkUnclaimed;
        private MetroFramework.Controls.MetroTextBox txtOrNum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}