namespace Tailor
{
    partial class frmStaff
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
            this.txtCurrentAddress = new System.Windows.Forms.RichTextBox();
            this.txtBirthPlace = new System.Windows.Forms.RichTextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.txtNameKh = new System.Windows.Forms.TextBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtCurrentAddress);
            this.panel1.Controls.Add(this.txtBirthPlace);
            this.panel1.Controls.Add(this.txtBasicSalary);
            this.panel1.Controls.Add(this.cboGender);
            this.panel1.Controls.Add(this.cboSkill);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpBirthDate);
            this.panel1.Controls.Add(this.txtNationalId);
            this.panel1.Controls.Add(this.txtNameEn);
            this.panel1.Controls.Add(this.txtNameKh);
            this.panel1.Controls.Add(this.lblFinished);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 431);
            this.panel1.TabIndex = 0;
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(612, 270);
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(250, 80);
            this.txtCurrentAddress.TabIndex = 9;
            this.txtCurrentAddress.Text = "";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(165, 270);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(250, 80);
            this.txtBirthPlace.TabIndex = 4;
            this.txtBirthPlace.Text = "";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(612, 203);
            this.txtBasicSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(250, 32);
            this.txtBasicSalary.TabIndex = 8;
            this.txtBasicSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasicSalary_KeyPress);
            // 
            // cboGender
            // 
            this.cboGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(165, 69);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(250, 32);
            this.cboGender.TabIndex = 1;
            // 
            // cboSkill
            // 
            this.cboSkill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Location = new System.Drawing.Point(165, 203);
            this.cboSkill.Margin = new System.Windows.Forms.Padding(2);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(250, 32);
            this.cboSkill.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(612, 136);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 32);
            this.txtPhone.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(0, 382);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(870, 2);
            this.label11.TabIndex = 57;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(165, 136);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(250, 32);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // txtNationalId
            // 
            this.txtNationalId.Location = new System.Drawing.Point(612, 69);
            this.txtNationalId.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(250, 32);
            this.txtNationalId.TabIndex = 6;
            this.txtNationalId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalId_KeyPress);
            // 
            // txtNameEn
            // 
            this.txtNameEn.Location = new System.Drawing.Point(612, 2);
            this.txtNameEn.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(250, 32);
            this.txtNameEn.TabIndex = 5;
            this.txtNameEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameEn_KeyPress);
            this.txtNameEn.Leave += new System.EventHandler(this.txtNameEn_Leave);
            // 
            // txtNameKh
            // 
            this.txtNameKh.Location = new System.Drawing.Point(165, 2);
            this.txtNameKh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameKh.Name = "txtNameKh";
            this.txtNameKh.Size = new System.Drawing.Size(250, 32);
            this.txtNameKh.TabIndex = 0;
            // 
            // lblFinished
            // 
            this.lblFinished.Image = global::Tailor.Properties.Resources._checked_16;
            this.lblFinished.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFinished.Location = new System.Drawing.Point(447, 399);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(160, 25);
            this.lblFinished.TabIndex = 48;
            this.lblFinished.Text = "      រួចរាល់";
            this.lblFinished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(2, 399);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(320, 25);
            this.lblCode.TabIndex = 48;
            this.lblCode.Text = "លេខកូដសម្គាល់ : ";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(2, 273);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 25);
            this.label15.TabIndex = 48;
            this.label15.Text = "ទីកន្លែងកំណើត :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(2, 206);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "ផ្នែក ឬ ជំនាញ :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(2, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "ថ្ងៃខែឆ្នាំកំណើត :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(2, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 48;
            this.label12.Text = "ភេទ :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(447, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "អាស័យដ្ខានបច្ចុប្បន្ន :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(448, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "ប្រាក់ខែគោល ($) :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(448, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "លេខទូរស័ព្ទ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(448, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "លេខអត្តសញ្ញាណប័ណ្ណ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(448, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "ឈ្មោះ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "ឈ្មោះ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(742, 394);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "បោះបង់";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(612, 394);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Info";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtCurrentAddress;
        private System.Windows.Forms.RichTextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboSkill;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.TextBox txtNameKh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblCode;
    }
}