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
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            using(var db = new TailorEntities())
            {
                var query = db.Staffs.Where(s => s.IsActive).ToList();
                var attendances = db.StaffAttendances.Where(a => a.Date.Month==dtpAttendanceDate.Value.Month).ToList();

                foreach (var s in query)
                {
                    int isExist = 0;
                    foreach (var a in attendances)
                    {
                        if(s.Code==a.Staff.Code && a.Date==dtpAttendanceDate.Value.Date)
                        {
                            isExist = 1;
                        }
                    }
                    if(isExist==0)
                    {
                        var attendance = new StaffAttendance()
                        {
                            StaffCode = s.Code,
                            Date = dtpAttendanceDate.Value,
                            Status = "W",
                            ComputerCode = TailorService.GetComputerCode(),
                            ComputeTime = TailorService.GetComputerTime()
                        };
                        db.StaffAttendances.Add(attendance);
                        
                    }
                }
                db.SaveChanges();
            }
            LoadStaffAttendance();
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

                dgvList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (DataGridViewColumn col in dgvList.Columns)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            staffAttendance.staffAttendanceView = this;
            staffAttendance.ShowDialog();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStaffAttendance staffAttedance = new frmStaffAttendance();
            staffAttedance.staffAttendanceView = this;
            staffAttedance.ShowDialog();
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            using(var db = new TailorEntities())
            {
                var query = db.StaffAttendances.Where(s => s.Staff.NameKh.Contains(txtSeach.Text.Trim())).ToList();
                dgvList.Rows.Clear();
                foreach (var a in query)
                {
                    dgvList.Rows.Add("", a.StaffCode, a.Staff.NameKh, a.Staff.Gender.Description, a.Date, a.Status, a.Remark);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var query = db.StaffAttendances.Where(a => a.Date >= dtpFromDate.Value.Date && a.Date <= dtpUntillDate.Value.Date).ToList();
                dgvList.Rows.Clear();
                foreach (var a in query)
                {
                    dgvList.Rows.Add("", a.StaffCode, a.Staff.NameKh, a.Staff.Gender.Description, a.Date.ToShortDateString(), a.Status, a.Remark);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
        }
    }
}
