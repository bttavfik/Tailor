using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Tailor.Model;
using Tailor.Services;

namespace Tailor
{
    public partial class frmStaffBonus : Form
    {
        public frmStaffBonus()
        {
            InitializeComponent();
        }

        private void frmStaffBonus_Load(object sender, EventArgs e)
        {
            LoadStaffCode();
            LoadStaffName();

            cboCode.SelectedIndex = -1;
            cboStaff.SelectedIndex = -1;

            lblFinished.Visible = false;
            lblDate.Visible = false;

            this.cboCode.SelectedIndexChanged += new System.EventHandler(this.cboCode_SelectedIndexChanged);
            this.cboStaff.SelectedIndexChanged += new System.EventHandler(this.cboStaff_SelectedIndexChanged);
        }

        private void LoadStaffCode()
        {
            using(var db = new TailorEntities())
            {
                var staffCode = db.Staffs.Where(s => s.IsActive).ToList();
                cboCode.DataSource = staffCode;
                cboCode.DisplayMember = "Code";
                cboCode.ValueMember = "Code";
            }
        }

        private void LoadStaffName()
        {
            using (var db = new TailorEntities())
            {
                var staffName = db.Staffs.Where(s => s.IsActive).ToList();
                cboStaff.DataSource = staffName;
                cboStaff.DisplayMember = "NameKh";
                cboStaff.ValueMember = "Code";
            }
        }

        private void cboCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var staff = db.Staffs.SingleOrDefault(s => s.Code == cboCode.SelectedValue.ToString());
                cboStaff.SelectedValue = staff.Code;
            }
        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var staff = db.Staffs.SingleOrDefault(s => s.Code == cboStaff.SelectedValue.ToString());
                cboCode.SelectedValue = staff.Code;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboCode.SelectedIndex < 0)
            {
                cboCode.Focus();
                error.SetError(cboCode, null);
                return;
            }

            if(cboStaff.SelectedIndex < 0)
            {
                cboStaff.Focus();
                error.SetError(cboStaff, null);
                return;
            }

            if (string.IsNullOrEmpty(txtAmount.Text.Trim()))
            {
                txtAmount.Focus();
                error.SetError(txtAmount, null);
                return;
            }

            using(var db = new TailorEntities())
            {
                StaffBonu bonus = new StaffBonu()
                {
                    StaffCode = cboStaff.SelectedValue.ToString(),
                    Date = dtpDate.Value,
                    Amount = decimal.Parse(txtAmount.Text),
                    Remark = txtReason.Text,
                    ComputerCode = TailorService.GetComputerCode(),
                    ComputeTime = TailorService.GetComputerTime()
                };
                db.StaffBonus.Add(bonus);
                int action = db.SaveChanges();
                if(action >= 1)
                {
                    lblFinished.Visible = true;
                }
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' || !Decimal.TryParse(txtAmount.Text + e.KeyChar, out x))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
