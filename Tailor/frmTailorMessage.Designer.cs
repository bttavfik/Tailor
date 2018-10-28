namespace Tailor
{
    partial class frmTailorMessage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pcbMessageIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessageText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcbMessageIcon);
            this.panel1.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 96);
            this.panel1.TabIndex = 0;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AllowDrop = true;
            this.lblMessageText.AutoEllipsis = true;
            this.lblMessageText.Location = new System.Drawing.Point(89, 3);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(248, 80);
            this.lblMessageText.TabIndex = 3;
            this.lblMessageText.Text = "ខ្លឹមសារ ជូនដំណឹង?";
            this.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 2);
            this.label1.TabIndex = 2;
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(186, 111);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(80, 30);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "បាទ/ចាស";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(272, 111);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(80, 30);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "ទេ";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pcbMessageIcon
            // 
            this.pcbMessageIcon.Image = global::Tailor.Properties.Resources._question_icon;
            this.pcbMessageIcon.Location = new System.Drawing.Point(3, 3);
            this.pcbMessageIcon.Name = "pcbMessageIcon";
            this.pcbMessageIcon.Size = new System.Drawing.Size(80, 80);
            this.pcbMessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMessageIcon.TabIndex = 0;
            this.pcbMessageIcon.TabStop = false;
            // 
            // frmTailorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 153);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTailorMessage";
            this.Text = "Tailor message";
            this.Load += new System.EventHandler(this.frmTailorMessage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMessageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbMessageIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}