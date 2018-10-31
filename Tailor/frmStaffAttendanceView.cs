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
    public partial class frmStaffAttendanceView : Form
    {
        string code;
        int index = -1;
        DateTime date;

        public frmStaffAttendanceView()
        {
            InitializeComponent();
        }

        private void frmStaffAttendanceView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadStaffAttendance();
            LoadAttendanceInfo();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //Load frmAddAttendance
            frmAddAttendance attendance = new frmAddAttendance();
            attendance.view = this;
            attendance.ShowDialog();

            //Load frmStaffAttendance
            frmStaffAttendance staffAttendance = new frmStaffAttendance();
            staffAttendance.AttendanceView = this;
            staffAttendance.ShowDialog();
        }

        public void LoadStaffAttendance()
        {
            using(var db = new TailorEntities())
            {
                var query = db.StaffAttendances.Where(s => s.Date == DateTime.Today).ToList();
                dgvList.Rows.Clear();
                foreach (var a in query)
                {
                    dgvList.Rows.Add("", a.StaffCode, a.Staff.NameKh, a.Staff.Gender.Description, a.Date, a.Status, a.Remark);
                }
                TailorService.GenerateRowNumber(dgvList);

                foreach (DataGridViewColumn col in dgvList.Columns)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        public void LoadAttendanceInfo()
        {
            using(var db = new TailorEntities())
            {
                var work = db.StaffAttendances.Where(a => a.Date == DateTime.Today && a.Status == "W").Count();
                lblW.Text = work + " នាក់";

                var permission = db.StaffAttendances.Where(a => a.Date == DateTime.Today && a.Status == "P").Count();
                lblP.Text = permission + " នាក់";

                var absent = db.StaffAttendances.Where(a => a.Date == DateTime.Today && a.Status == "A").Count();
                lblA.Text = absent + " នាក់";

                var all = db.StaffAttendances.Where(a => a.Date == DateTime.Today).Count();
                lblAll.Text = all + " នាក់";
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(dgvList.RowCount > 0)
            {
                if (index < 0)
                    return;
                code = dgvList.Rows[index].Cells[1].Value.ToString();
                date = DateTime.Parse(dgvList.Rows[index].Cells[4].Value.ToString());
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (index < 0)
                return;
            frmStaffAttendance staffAttendance = new frmStaffAttendance();
            staffAttendance.edit = true;
            staffAttendance.code = code;
            staffAttendance.date = date;
            staffAttendance.AttendanceView = this;
            staffAttendance.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var query = db.StaffAttendances.Where(a => a.Date >= dtpFromDate.Value.Date && a.Date <= dtpUntillDate.Value.Date).OrderByDescending(a => a.Date).ToList();
                dgvList.Rows.Clear();
                foreach (var a in query)
                {
                    dgvList.Rows.Add("", a.StaffCode, a.Staff.NameKh, a.Staff.Gender.Description, a.Date.ToShortDateString(), a.Status, a.Remark);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStaffAttendance staffAttedance = new frmStaffAttendance();
            staffAttedance.AttendanceView = this;
            staffAttedance.ShowDialog();
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var query = db.StaffAttendances.Where(a => a.Staff.NameKh.Contains(txtSeach.Text.Trim()) || a.StaffCode.ToLower().Contains(txtSeach.Text.Trim().ToLower())).OrderByDescending(a => a.Date).ToList();

                dgvList.Rows.Clear();
                foreach (var a in query)
                {
                    dgvList.Rows.Add("", a.StaffCode, a.Staff.NameKh, a.Staff.Gender.Description, a.Date, a.Status, a.Remark);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
        }
    }
}
