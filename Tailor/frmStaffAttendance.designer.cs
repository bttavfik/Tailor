namespace Tailor
{
    partial class frmStaffAttendance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFinished = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnP = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpUntillDate = new System.Windows.Forms.DateTimePicker();
            this.lblUntillDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblFinished);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.cboCode);
            this.panel1.Controls.Add(this.cboStaff);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 431);
            this.panel1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Image = global::Tailor.Properties.Resources._warning_16;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(2, 399);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 25);
            this.lblDate.TabIndex = 55;
            this.lblDate.Text = "      កាលបរិច្ឆេទ មិនត្រឹមត្រូវ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinished
            // 
            this.lblFinished.Image = global::Tailor.Properties.Resources._checked_16;
            this.lblFinished.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFinished.Location = new System.Drawing.Point(453, 399);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(160, 25);
            this.lblFinished.TabIndex = 55;
            this.lblFinished.Text = "      រួចរាល់";
            this.lblFinished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbtnA);
            this.panel3.Controls.Add(this.rbtnP);
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 80);
            this.panel3.TabIndex = 54;
            this.panel3.TabStop = true;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(23, 25);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(107, 29);
            this.rbtnA.TabIndex = 2;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "ឈប់ឥតច្បាប់";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnP
            // 
            this.rbtnP.AutoSize = true;
            this.rbtnP.Location = new System.Drawing.Point(166, 25);
            this.rbtnP.Name = "rbtnP";
            this.rbtnP.Size = new System.Drawing.Size(111, 29);
            this.rbtnP.TabIndex = 3;
            this.rbtnP.TabStop = true;
            this.rbtnP.Text = "ឈប់មានច្បាប់";
            this.rbtnP.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.dtpUntillDate);
            this.panel2.Controls.Add(this.lblUntillDate);
            this.panel2.Controls.Add(this.lblFromDate);
            this.panel2.Location = new System.Drawing.Point(0, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 140);
            this.panel2.TabIndex = 52;
            this.panel2.TabStop = true;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(186, 24);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 32);
            this.dtpFromDate.TabIndex = 4;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpUntillDate
            // 
            this.dtpUntillDate.CustomFormat = "dd/MM/yyyy";
            this.dtpUntillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntillDate.Location = new System.Drawing.Point(186, 83);
            this.dtpUntillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUntillDate.Name = "dtpUntillDate";
            this.dtpUntillDate.Size = new System.Drawing.Size(200, 32);
            this.dtpUntillDate.TabIndex = 5;
            this.dtpUntillDate.ValueChanged += new System.EventHandler(this.dtpUntillDate_ValueChanged);
            // 
            // lblUntillDate
            // 
            this.lblUntillDate.Location = new System.Drawing.Point(27, 89);
            this.lblUntillDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUntillDate.Name = "lblUntillDate";
            this.lblUntillDate.Size = new System.Drawing.Size(155, 25);
            this.lblUntillDate.TabIndex = 51;
            this.lblUntillDate.Text = "រហូតដល់ថ្ងៃទី :";
            this.lblUntillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(27, 30);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(155, 25);
            this.lblFromDate.TabIndex = 51;
            this.lblFromDate.Text = "ចាប់ពីថ្ងៃទី :";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(453, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "មូលហេតុ​ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "ឈ្មោះ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(2, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "កូដសម្គាល់ :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(2, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(865, 2);
            this.label4.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(757, 394);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "បោះបង់";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(617, 2);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(250, 359);
            this.txtReason.TabIndex = 6;
            this.txtReason.Text = "";
            // 
            // cboCode
            // 
            this.cboCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCode.FormattingEnabled = true;
            this.cboCode.IntegralHeight = false;
            this.cboCode.Location = new System.Drawing.Point(166, 2);
            this.cboCode.Margin = new System.Windows.Forms.Padding(2);
            this.cboCode.MaxDropDownItems = 5;
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(250, 32);
            this.cboCode.TabIndex = 0;
            // 
            // cboStaff
            // 
            this.cboStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.IntegralHeight = false;
            this.cboStaff.Location = new System.Drawing.Point(166, 59);
            this.cboStaff.Margin = new System.Windows.Forms.Padding(2);
            this.cboStaff.MaxDropDownItems = 5;
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(250, 32);
            this.cboStaff.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(643, 394);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmStaffAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaffAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff attendance";
            this.Load += new System.EventHandler(this.frmStaffPermission_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpUntillDate;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.Label lblUntillDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnP;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ErrorProvider error;
    }
}