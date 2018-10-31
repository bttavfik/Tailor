using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tailor.Model;
using Tailor.Services;

namespace Tailor
{
    public partial class frmStaffAttendance : Form
    {

        public frmStaffAttendanceView AttendanceView = null;
        public string code;
        public bool edit = false;
        public DateTime date;

        public frmStaffAttendance()
        {
            InitializeComponent();
        }

        private void frmStaffPermission_Load(object sender, EventArgs e)
        {

            lblDate.Visible = false;
            lblFinished.Visible = false;
            LoadStaffCode();
            LoadStaffName();

            rbtnA.Checked = true;

            cboCode.SelectedIndex = -1;
            cboStaff.SelectedIndex = -1;

            this.cboCode.SelectedIndexChanged += new System.EventHandler(this.cboCode_SelectedIndexChanged);
            this.cboStaff.SelectedIndexChanged += new System.EventHandler(this.cboStaff_SelectedIndexChanged);

            if (edit)
            {
                this.Edit();
            }
        }

        private void LoadStaffCode()
        {
            using (var db = new TailorEntities())
            {
                var staff = db.Staffs.Where(s => s.IsActive).ToList();
                cboCode.DataSource = staff;
                cboCode.DisplayMember = "Code";
                cboCode.ValueMember = "Code";
            }
        }

        private void LoadStaffName()
        {
            using (var db = new TailorEntities())
            {
                var staff = db.Staffs.Where(s => s.IsActive).ToList();
                cboStaff.DataSource = staff;
                cboStaff.DisplayMember = "NameKh";
                cboStaff.ValueMember = "Code";
            }
        }

        private void Edit()
        {
            using(var db = new TailorEntities())
            {
                var query = db.StaffAttendances.SingleOrDefault(s => s.StaffCode == code && s.Date == date);
                cboCode.SelectedValue = code;
                if (query.Status == "P")
                    rbtnP.Checked = true;
                else if (query.Status == "A")
                    rbtnA.Checked = true;
                else
                {
                    rbtnA.Checked = false;
                    rbtnP.Checked = false;
                }
                dtpFromDate.Value = query.Date;
                dtpUntillDate.Value = query.Date;
                dtpFromDate.Enabled = false;
                dtpUntillDate.Enabled = false;
                txtReason.Text = query.Remark;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCode.SelectedIndex < 0)
            {
                error.SetError(cboCode, null);
                cboCode.Focus();
                return;
            }

            if (cboStaff.SelectedIndex < 0)
            {
                error.SetError(cboStaff, null);
                cboStaff.Focus();
                return;
            }

            if (dtpUntillDate.Value < dtpFromDate.Value)
            {
                error.SetError(dtpUntillDate, null);
                dtpUntillDate.Focus();
                return;
            }

            string status = rbtnA.Checked ? "A" : "P";

            DateTime startDate = dtpFromDate.Value;
            DateTime endDate = dtpUntillDate.Value;

            if (edit)
            {
                using (var db = new TailorEntities())
                {
                    var query = db.StaffAttendances.SingleOrDefault(a => a.StaffCode == code && a.Date == date);
                    query.Status = status;
                    query.Remark = txtReason.Text;

                    int action = db.SaveChanges();
                    if (action >= 1)
                        lblFinished.Visible = true;
                }
            }
            else
            {
                using (var db = new TailorEntities())
                {
                    var query = db.StaffAttendances.Where(a => a.Date.Month == dtpFromDate.Value.Month || a.Date.Month == dtpUntillDate.Value.Month).ToList();

                    for (DateTime date = startDate.Date; date <= endDate.Date; date = date.AddDays(1))
                    {
                        int isExist = 0;
                        foreach (var a in query)
                        {
                            if(a.StaffCode == cboCode.SelectedValue.ToString() && a.Date.Date == date)
                            {
                                isExist = 1;
                            } 
                        }
                        if (isExist == 0)
                        {
                            StaffAttendance attendance = new StaffAttendance()
                            {
                                StaffCode = cboCode.SelectedValue.ToString(),
                                Date = date,
                                Status = status,
                                Remark = txtReason.Text,
                                ComputerCode = TailorService.GetComputerCode(),
                                ComputeTime = TailorService.GetComputerTime()
                            };
                            db.StaffAttendances.Add(attendance);
                        }
                    }
                    int action = db.SaveChanges();
                    if (action >= 1)
                        lblFinished.Visible = true;
                }
            }
            if (AttendanceView != null)
            {
                AttendanceView.LoadStaffAttendance();
                AttendanceView.LoadAttendanceInfo();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (edit)
                return;
            if (dtpUntillDate.Value < dtpFromDate.Value)
                lblDate.Visible = true;
            else
                lblDate.Visible = false;

            lblFinished.Visible = false;
        }

        private void dtpUntillDate_ValueChanged(object sender, EventArgs e)
        {
            if (edit)
                return;
            if (dtpUntillDate.Value < dtpFromDate.Value)
                lblDate.Visible = true;
            else
                lblDate.Visible = false;

            lblFinished.Visible = false;
        }
    }
}
