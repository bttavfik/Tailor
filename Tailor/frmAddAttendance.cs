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
    public partial class frmAddAttendance : Form
    {

        public frmStaffAttendanceView view = null;

        public frmAddAttendance()
        {
            InitializeComponent();
        }

        private void frmAddAttendance_Load(object sender, EventArgs e)
        {
            lblFinished.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new TailorEntities())
            {
                var query = db.Staffs.Where(s => s.IsActive).ToList();
                var attendances = db.StaffAttendances.Where(a => a.Date.Month == dtpAttendanceDate.Value.Month).ToList();

                foreach (var s in query)
                {
                    int isExist = 0;
                    foreach (var a in attendances)
                    {
                        if (s.Code == a.Staff.Code && a.Date == dtpAttendanceDate.Value.Date)
                        {
                            isExist = 1;
                        }
                    }
                    if (isExist == 0)
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
                int action = db.SaveChanges();
                if (action >= 1)
                {
                    progressBar1.Value = 100;
                    lblFinished.Visible = true;
                }
            }

            if(view != null)
            {
                view.LoadStaffAttendance();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            lblFinished.Visible = false;
            progressBar1.Value = 0;
        }
    }
}
