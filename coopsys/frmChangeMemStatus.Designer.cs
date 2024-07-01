namespace coopsys
{
    partial class frmChangeMemStatus
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
            this.rbtnActive = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnInactive = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnWithdraw = new MetroFramework.Controls.MetroRadioButton();
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
            this.btnSave.Location = new System.Drawing.Point(277, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnActive.Location = new System.Drawing.Point(26, 84);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(66, 20);
            this.rbtnActive.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbtnActive.TabIndex = 14;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseSelectable = true;
            this.rbtnActive.CheckedChanged += new System.EventHandler(this.rbtnActive_CheckedChanged);
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnInactive.Location = new System.Drawing.Point(26, 127);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(76, 20);
            this.rbtnInactive.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbtnInactive.TabIndex = 15;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseSelectable = true;
            this.rbtnInactive.CheckedChanged += new System.EventHandler(this.rbtnInactive_CheckedChanged);
            // 
            // rbtnWithdraw
            // 
            this.rbtnWithdraw.AutoSize = true;
            this.rbtnWithdraw.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnWithdraw.Location = new System.Drawing.Point(26, 169);
            this.rbtnWithdraw.Name = "rbtnWithdraw";
            this.rbtnWithdraw.Size = new System.Drawing.Size(89, 20);
            this.rbtnWithdraw.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbtnWithdraw.TabIndex = 16;
            this.rbtnWithdraw.Text = "Withdraw";
            this.rbtnWithdraw.UseSelectable = true;
            this.rbtnWithdraw.CheckedChanged += new System.EventHandler(this.rbtnWithdraw_CheckedChanged);
            // 
            // frmChangeMemStatus
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 275);
            this.Controls.Add(this.rbtnWithdraw);
            this.Controls.Add(this.rbtnInactive);
            this.Controls.Add(this.rbtnActive);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmChangeMemStatus";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Change Member Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroRadioButton rbtnActive;
        private MetroFramework.Controls.MetroRadioButton rbtnInactive;
        private MetroFramework.Controls.MetroRadioButton rbtnWithdraw;
    }
}