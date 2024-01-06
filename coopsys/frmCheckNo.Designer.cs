namespace coopsys
{
    partial class frmCheckNo
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
            this.txtCheckNo = new MetroFramework.Controls.MetroTextBox();
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
            this.btnSave.Location = new System.Drawing.Point(277, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCheckNo
            // 
            // 
            // 
            // 
            this.txtCheckNo.CustomButton.Image = null;
            this.txtCheckNo.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.txtCheckNo.CustomButton.Name = "";
            this.txtCheckNo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCheckNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCheckNo.CustomButton.TabIndex = 1;
            this.txtCheckNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCheckNo.CustomButton.UseSelectable = true;
            this.txtCheckNo.CustomButton.Visible = false;
            this.txtCheckNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCheckNo.Lines = new string[0];
            this.txtCheckNo.Location = new System.Drawing.Point(23, 119);
            this.txtCheckNo.MaxLength = 32767;
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.PasswordChar = '\0';
            this.txtCheckNo.PromptText = "Check Number";
            this.txtCheckNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCheckNo.SelectedText = "";
            this.txtCheckNo.SelectionLength = 0;
            this.txtCheckNo.SelectionStart = 0;
            this.txtCheckNo.ShortcutsEnabled = true;
            this.txtCheckNo.Size = new System.Drawing.Size(389, 27);
            this.txtCheckNo.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCheckNo.TabIndex = 11;
            this.txtCheckNo.UseSelectable = true;
            this.txtCheckNo.WaterMark = "Check Number";
            this.txtCheckNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCheckNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCheckNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 231);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCheckNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckNo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Enter Check No.";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtCheckNo;
    }
}