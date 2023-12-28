namespace coopsys
{
    partial class frmPenalty
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
            this.txtPenalty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
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
            this.btnSave.Location = new System.Drawing.Point(344, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPenalty
            // 
            // 
            // 
            // 
            this.txtPenalty.CustomButton.Image = null;
            this.txtPenalty.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPenalty.CustomButton.Name = "";
            this.txtPenalty.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPenalty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPenalty.CustomButton.TabIndex = 1;
            this.txtPenalty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPenalty.CustomButton.UseSelectable = true;
            this.txtPenalty.CustomButton.Visible = false;
            this.txtPenalty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPenalty.Lines = new string[0];
            this.txtPenalty.Location = new System.Drawing.Point(119, 75);
            this.txtPenalty.MaxLength = 32767;
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.PasswordChar = '\0';
            this.txtPenalty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPenalty.SelectedText = "";
            this.txtPenalty.SelectionLength = 0;
            this.txtPenalty.SelectionStart = 0;
            this.txtPenalty.ShortcutsEnabled = true;
            this.txtPenalty.Size = new System.Drawing.Size(219, 27);
            this.txtPenalty.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPenalty.TabIndex = 18;
            this.txtPenalty.UseSelectable = true;
            this.txtPenalty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPenalty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Amount:";
            // 
            // frmPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 136);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.metroLabel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPenalty";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Set Loan Penalty";
            this.Load += new System.EventHandler(this.frmPenalty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtPenalty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}