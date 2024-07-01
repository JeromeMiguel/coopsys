namespace coopsys
{
    partial class frmCollateral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPropLoc = new MetroFramework.Controls.MetroTextBox();
            this.txtPropArea = new MetroFramework.Controls.MetroTextBox();
            this.txtPropSurvey = new MetroFramework.Controls.MetroTextBox();
            this.txtPropDesc = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVehMake = new MetroFramework.Controls.MetroTextBox();
            this.txtVehChassis = new MetroFramework.Controls.MetroTextBox();
            this.txtVehEngine = new MetroFramework.Controls.MetroTextBox();
            this.txtVehPlate = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBank = new MetroFramework.Controls.MetroTextBox();
            this.txtChqAmt = new MetroFramework.Controls.MetroTextBox();
            this.txtChqNum = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPropLoc);
            this.groupBox1.Controls.Add(this.txtPropArea);
            this.groupBox1.Controls.Add(this.txtPropSurvey);
            this.groupBox1.Controls.Add(this.txtPropDesc);
            this.groupBox1.Location = new System.Drawing.Point(23, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Real Property";
            // 
            // txtPropLoc
            // 
            // 
            // 
            // 
            this.txtPropLoc.CustomButton.Image = null;
            this.txtPropLoc.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPropLoc.CustomButton.Name = "";
            this.txtPropLoc.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txtPropLoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPropLoc.CustomButton.TabIndex = 1;
            this.txtPropLoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPropLoc.CustomButton.UseSelectable = true;
            this.txtPropLoc.CustomButton.Visible = false;
            this.txtPropLoc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPropLoc.Lines = new string[0];
            this.txtPropLoc.Location = new System.Drawing.Point(19, 188);
            this.txtPropLoc.MaxLength = 32767;
            this.txtPropLoc.Multiline = true;
            this.txtPropLoc.Name = "txtPropLoc";
            this.txtPropLoc.PasswordChar = '\0';
            this.txtPropLoc.PromptText = "Location";
            this.txtPropLoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPropLoc.SelectedText = "";
            this.txtPropLoc.SelectionLength = 0;
            this.txtPropLoc.SelectionStart = 0;
            this.txtPropLoc.ShortcutsEnabled = true;
            this.txtPropLoc.Size = new System.Drawing.Size(276, 99);
            this.txtPropLoc.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPropLoc.TabIndex = 13;
            this.txtPropLoc.UseSelectable = true;
            this.txtPropLoc.WaterMark = "Location";
            this.txtPropLoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPropLoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPropArea
            // 
            // 
            // 
            // 
            this.txtPropArea.CustomButton.Image = null;
            this.txtPropArea.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtPropArea.CustomButton.Name = "";
            this.txtPropArea.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPropArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPropArea.CustomButton.TabIndex = 1;
            this.txtPropArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPropArea.CustomButton.UseSelectable = true;
            this.txtPropArea.CustomButton.Visible = false;
            this.txtPropArea.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPropArea.Lines = new string[0];
            this.txtPropArea.Location = new System.Drawing.Point(19, 137);
            this.txtPropArea.MaxLength = 32767;
            this.txtPropArea.Multiline = true;
            this.txtPropArea.Name = "txtPropArea";
            this.txtPropArea.PasswordChar = '\0';
            this.txtPropArea.PromptText = "Area of";
            this.txtPropArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPropArea.SelectedText = "";
            this.txtPropArea.SelectionLength = 0;
            this.txtPropArea.SelectionStart = 0;
            this.txtPropArea.ShortcutsEnabled = true;
            this.txtPropArea.Size = new System.Drawing.Size(276, 31);
            this.txtPropArea.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPropArea.TabIndex = 12;
            this.txtPropArea.UseSelectable = true;
            this.txtPropArea.WaterMark = "Area of";
            this.txtPropArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPropArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPropSurvey
            // 
            // 
            // 
            // 
            this.txtPropSurvey.CustomButton.Image = null;
            this.txtPropSurvey.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtPropSurvey.CustomButton.Name = "";
            this.txtPropSurvey.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPropSurvey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPropSurvey.CustomButton.TabIndex = 1;
            this.txtPropSurvey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPropSurvey.CustomButton.UseSelectable = true;
            this.txtPropSurvey.CustomButton.Visible = false;
            this.txtPropSurvey.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPropSurvey.Lines = new string[0];
            this.txtPropSurvey.Location = new System.Drawing.Point(19, 84);
            this.txtPropSurvey.MaxLength = 32767;
            this.txtPropSurvey.Multiline = true;
            this.txtPropSurvey.Name = "txtPropSurvey";
            this.txtPropSurvey.PasswordChar = '\0';
            this.txtPropSurvey.PromptText = "Survey Number";
            this.txtPropSurvey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPropSurvey.SelectedText = "";
            this.txtPropSurvey.SelectionLength = 0;
            this.txtPropSurvey.SelectionStart = 0;
            this.txtPropSurvey.ShortcutsEnabled = true;
            this.txtPropSurvey.Size = new System.Drawing.Size(276, 31);
            this.txtPropSurvey.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPropSurvey.TabIndex = 11;
            this.txtPropSurvey.UseSelectable = true;
            this.txtPropSurvey.WaterMark = "Survey Number";
            this.txtPropSurvey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPropSurvey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPropDesc
            // 
            // 
            // 
            // 
            this.txtPropDesc.CustomButton.Image = null;
            this.txtPropDesc.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtPropDesc.CustomButton.Name = "";
            this.txtPropDesc.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPropDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPropDesc.CustomButton.TabIndex = 1;
            this.txtPropDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPropDesc.CustomButton.UseSelectable = true;
            this.txtPropDesc.CustomButton.Visible = false;
            this.txtPropDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPropDesc.Lines = new string[0];
            this.txtPropDesc.Location = new System.Drawing.Point(19, 33);
            this.txtPropDesc.MaxLength = 32767;
            this.txtPropDesc.Multiline = true;
            this.txtPropDesc.Name = "txtPropDesc";
            this.txtPropDesc.PasswordChar = '\0';
            this.txtPropDesc.PromptText = "Description TCT No.";
            this.txtPropDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPropDesc.SelectedText = "";
            this.txtPropDesc.SelectionLength = 0;
            this.txtPropDesc.SelectionStart = 0;
            this.txtPropDesc.ShortcutsEnabled = true;
            this.txtPropDesc.Size = new System.Drawing.Size(276, 31);
            this.txtPropDesc.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtPropDesc.TabIndex = 10;
            this.txtPropDesc.UseSelectable = true;
            this.txtPropDesc.WaterMark = "Description TCT No.";
            this.txtPropDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPropDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVehMake);
            this.groupBox2.Controls.Add(this.txtVehChassis);
            this.groupBox2.Controls.Add(this.txtVehEngine);
            this.groupBox2.Controls.Add(this.txtVehPlate);
            this.groupBox2.Location = new System.Drawing.Point(367, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 247);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor Vehicle";
            // 
            // txtVehMake
            // 
            // 
            // 
            // 
            this.txtVehMake.CustomButton.Image = null;
            this.txtVehMake.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtVehMake.CustomButton.Name = "";
            this.txtVehMake.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtVehMake.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehMake.CustomButton.TabIndex = 1;
            this.txtVehMake.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehMake.CustomButton.UseSelectable = true;
            this.txtVehMake.CustomButton.Visible = false;
            this.txtVehMake.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVehMake.Lines = new string[0];
            this.txtVehMake.Location = new System.Drawing.Point(19, 188);
            this.txtVehMake.MaxLength = 32767;
            this.txtVehMake.Multiline = true;
            this.txtVehMake.Name = "txtVehMake";
            this.txtVehMake.PasswordChar = '\0';
            this.txtVehMake.PromptText = "Make/Series";
            this.txtVehMake.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehMake.SelectedText = "";
            this.txtVehMake.SelectionLength = 0;
            this.txtVehMake.SelectionStart = 0;
            this.txtVehMake.ShortcutsEnabled = true;
            this.txtVehMake.Size = new System.Drawing.Size(276, 31);
            this.txtVehMake.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtVehMake.TabIndex = 13;
            this.txtVehMake.UseSelectable = true;
            this.txtVehMake.WaterMark = "Make/Series";
            this.txtVehMake.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehMake.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVehChassis
            // 
            // 
            // 
            // 
            this.txtVehChassis.CustomButton.Image = null;
            this.txtVehChassis.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtVehChassis.CustomButton.Name = "";
            this.txtVehChassis.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtVehChassis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehChassis.CustomButton.TabIndex = 1;
            this.txtVehChassis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehChassis.CustomButton.UseSelectable = true;
            this.txtVehChassis.CustomButton.Visible = false;
            this.txtVehChassis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVehChassis.Lines = new string[0];
            this.txtVehChassis.Location = new System.Drawing.Point(19, 137);
            this.txtVehChassis.MaxLength = 32767;
            this.txtVehChassis.Multiline = true;
            this.txtVehChassis.Name = "txtVehChassis";
            this.txtVehChassis.PasswordChar = '\0';
            this.txtVehChassis.PromptText = "Chassis No.";
            this.txtVehChassis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehChassis.SelectedText = "";
            this.txtVehChassis.SelectionLength = 0;
            this.txtVehChassis.SelectionStart = 0;
            this.txtVehChassis.ShortcutsEnabled = true;
            this.txtVehChassis.Size = new System.Drawing.Size(276, 31);
            this.txtVehChassis.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtVehChassis.TabIndex = 12;
            this.txtVehChassis.UseSelectable = true;
            this.txtVehChassis.WaterMark = "Chassis No.";
            this.txtVehChassis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehChassis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVehEngine
            // 
            // 
            // 
            // 
            this.txtVehEngine.CustomButton.Image = null;
            this.txtVehEngine.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtVehEngine.CustomButton.Name = "";
            this.txtVehEngine.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtVehEngine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehEngine.CustomButton.TabIndex = 1;
            this.txtVehEngine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehEngine.CustomButton.UseSelectable = true;
            this.txtVehEngine.CustomButton.Visible = false;
            this.txtVehEngine.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVehEngine.Lines = new string[0];
            this.txtVehEngine.Location = new System.Drawing.Point(19, 84);
            this.txtVehEngine.MaxLength = 32767;
            this.txtVehEngine.Multiline = true;
            this.txtVehEngine.Name = "txtVehEngine";
            this.txtVehEngine.PasswordChar = '\0';
            this.txtVehEngine.PromptText = "Engine No.";
            this.txtVehEngine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehEngine.SelectedText = "";
            this.txtVehEngine.SelectionLength = 0;
            this.txtVehEngine.SelectionStart = 0;
            this.txtVehEngine.ShortcutsEnabled = true;
            this.txtVehEngine.Size = new System.Drawing.Size(276, 31);
            this.txtVehEngine.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtVehEngine.TabIndex = 11;
            this.txtVehEngine.UseSelectable = true;
            this.txtVehEngine.WaterMark = "Engine No.";
            this.txtVehEngine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehEngine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVehPlate
            // 
            // 
            // 
            // 
            this.txtVehPlate.CustomButton.Image = null;
            this.txtVehPlate.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtVehPlate.CustomButton.Name = "";
            this.txtVehPlate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtVehPlate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehPlate.CustomButton.TabIndex = 1;
            this.txtVehPlate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehPlate.CustomButton.UseSelectable = true;
            this.txtVehPlate.CustomButton.Visible = false;
            this.txtVehPlate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVehPlate.Lines = new string[0];
            this.txtVehPlate.Location = new System.Drawing.Point(19, 33);
            this.txtVehPlate.MaxLength = 32767;
            this.txtVehPlate.Multiline = true;
            this.txtVehPlate.Name = "txtVehPlate";
            this.txtVehPlate.PasswordChar = '\0';
            this.txtVehPlate.PromptText = "Plate No.";
            this.txtVehPlate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehPlate.SelectedText = "";
            this.txtVehPlate.SelectionLength = 0;
            this.txtVehPlate.SelectionStart = 0;
            this.txtVehPlate.ShortcutsEnabled = true;
            this.txtVehPlate.Size = new System.Drawing.Size(276, 31);
            this.txtVehPlate.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtVehPlate.TabIndex = 10;
            this.txtVehPlate.UseSelectable = true;
            this.txtVehPlate.WaterMark = "Plate No.";
            this.txtVehPlate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehPlate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBank);
            this.groupBox3.Controls.Add(this.txtChqAmt);
            this.groupBox3.Controls.Add(this.txtChqNum);
            this.groupBox3.Location = new System.Drawing.Point(713, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 193);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cheque";
            // 
            // txtBank
            // 
            // 
            // 
            // 
            this.txtBank.CustomButton.Image = null;
            this.txtBank.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtBank.CustomButton.Name = "";
            this.txtBank.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBank.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBank.CustomButton.TabIndex = 1;
            this.txtBank.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBank.CustomButton.UseSelectable = true;
            this.txtBank.CustomButton.Visible = false;
            this.txtBank.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBank.Lines = new string[0];
            this.txtBank.Location = new System.Drawing.Point(19, 137);
            this.txtBank.MaxLength = 32767;
            this.txtBank.Multiline = true;
            this.txtBank.Name = "txtBank";
            this.txtBank.PasswordChar = '\0';
            this.txtBank.PromptText = "Bank";
            this.txtBank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBank.SelectedText = "";
            this.txtBank.SelectionLength = 0;
            this.txtBank.SelectionStart = 0;
            this.txtBank.ShortcutsEnabled = true;
            this.txtBank.Size = new System.Drawing.Size(276, 31);
            this.txtBank.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtBank.TabIndex = 12;
            this.txtBank.UseSelectable = true;
            this.txtBank.WaterMark = "Bank";
            this.txtBank.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBank.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChqAmt
            // 
            // 
            // 
            // 
            this.txtChqAmt.CustomButton.Image = null;
            this.txtChqAmt.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtChqAmt.CustomButton.Name = "";
            this.txtChqAmt.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtChqAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChqAmt.CustomButton.TabIndex = 1;
            this.txtChqAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChqAmt.CustomButton.UseSelectable = true;
            this.txtChqAmt.CustomButton.Visible = false;
            this.txtChqAmt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtChqAmt.Lines = new string[0];
            this.txtChqAmt.Location = new System.Drawing.Point(19, 84);
            this.txtChqAmt.MaxLength = 32767;
            this.txtChqAmt.Multiline = true;
            this.txtChqAmt.Name = "txtChqAmt";
            this.txtChqAmt.PasswordChar = '\0';
            this.txtChqAmt.PromptText = "Cheque Amount";
            this.txtChqAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChqAmt.SelectedText = "";
            this.txtChqAmt.SelectionLength = 0;
            this.txtChqAmt.SelectionStart = 0;
            this.txtChqAmt.ShortcutsEnabled = true;
            this.txtChqAmt.Size = new System.Drawing.Size(276, 31);
            this.txtChqAmt.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtChqAmt.TabIndex = 11;
            this.txtChqAmt.UseSelectable = true;
            this.txtChqAmt.WaterMark = "Cheque Amount";
            this.txtChqAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChqAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChqNum
            // 
            // 
            // 
            // 
            this.txtChqNum.CustomButton.Image = null;
            this.txtChqNum.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.txtChqNum.CustomButton.Name = "";
            this.txtChqNum.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtChqNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChqNum.CustomButton.TabIndex = 1;
            this.txtChqNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChqNum.CustomButton.UseSelectable = true;
            this.txtChqNum.CustomButton.Visible = false;
            this.txtChqNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtChqNum.Lines = new string[0];
            this.txtChqNum.Location = new System.Drawing.Point(19, 33);
            this.txtChqNum.MaxLength = 32767;
            this.txtChqNum.Multiline = true;
            this.txtChqNum.Name = "txtChqNum";
            this.txtChqNum.PasswordChar = '\0';
            this.txtChqNum.PromptText = "Cheque No.";
            this.txtChqNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChqNum.SelectedText = "";
            this.txtChqNum.SelectionLength = 0;
            this.txtChqNum.SelectionStart = 0;
            this.txtChqNum.ShortcutsEnabled = true;
            this.txtChqNum.Size = new System.Drawing.Size(276, 31);
            this.txtChqNum.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtChqNum.TabIndex = 10;
            this.txtChqNum.UseSelectable = true;
            this.txtChqNum.WaterMark = "Cheque No.";
            this.txtChqNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChqNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnCancel.Location = new System.Drawing.Point(876, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(713, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdView
            // 
            this.grdView.AllowUserToResizeRows = false;
            this.grdView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdView.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdView.EnableHeadersVisualStyles = false;
            this.grdView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdView.Location = new System.Drawing.Point(195, 74);
            this.grdView.Name = "grdView";
            this.grdView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdView.RowHeadersWidth = 51;
            this.grdView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdView.Size = new System.Drawing.Size(240, 166);
            this.grdView.TabIndex = 18;
            this.grdView.Visible = false;
            // 
            // frmCollateral
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1050, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmCollateral";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Add Collateral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPropLoc;
        private MetroFramework.Controls.MetroTextBox txtPropArea;
        private MetroFramework.Controls.MetroTextBox txtPropSurvey;
        private MetroFramework.Controls.MetroTextBox txtPropDesc;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtVehMake;
        private MetroFramework.Controls.MetroTextBox txtVehChassis;
        private MetroFramework.Controls.MetroTextBox txtVehEngine;
        private MetroFramework.Controls.MetroTextBox txtVehPlate;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtChqAmt;
        private MetroFramework.Controls.MetroTextBox txtChqNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroGrid grdView;
        private MetroFramework.Controls.MetroTextBox txtBank;
    }
}