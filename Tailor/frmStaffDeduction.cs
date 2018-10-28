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
namespace Tailor
{
    public partial class frmStaffDeduction : Form
    {
        TailorEntities db = new TailorEntities();
        public int editId=0;
        public bool editFlag = false;
        public frmStaffDeduction()
        {
            InitializeComponent();
        }
        private void LoadStaff()
        {
            //to load gender in combo staff
            var staff = db.Staffs.Where(x => x.IsActive == true).ToList();
            cboStaff.DataSource = staff;
            cboStaff.DisplayMember = "NameKh";
            cboStaff.ValueMember = "Id";
            cboStaff.SelectedIndex = -1;
        }
        private void Edit()
        {
            //to Load data form datagridview to update
            if (editFlag)
            {
                var staff = db.StaffDeductions.Find(editId);
                cboStaff.SelectedValue = staff.StaffCode;
                dtpDate.Value = staff.Date;
                txtAmount.Text = staff.Amount.ToString();
                txtReason.Text = staff.Reason;
            }
        }
        private void frmStaffDeduction_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.LoadStaff();
            this.Edit();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update Staff
            if (editFlag)
            {
                var staff = db.StaffDeductions.Find(editId);
                staff.StaffCode = cboStaff.SelectedValue.ToString();
                staff.Date = dtpDate.Value;
                staff.Amount = (txtAmount.Text != null) ? decimal.Parse(txtAmount.Text) : 0;
                staff.Reason = txtReason.Text;
                staff.ComputerCode = Entities.TailorSetting.GetComputerCode();
                staff.ComputeTime = Entities.TailorSetting.GetComputerTime();

                editId = 0;
                editFlag = false;
                db.SaveChanges();
                return;
            }
            else
            {

                //Insert Staff Deduction
                var staff = new StaffDeduction()
                {
                    StaffCode = cboStaff.SelectedValue.ToString(),
                    Date = dtpDate.Value,
                    Amount = (!string.IsNullOrEmpty(txtAmount.Text.Trim()) ? decimal.Parse(txtAmount.Text) : 0),
                    Reason = txtReason.Text,
                    ComputerCode = Entities.TailorSetting.GetComputerCode(),
                    ComputeTime = Entities.TailorSetting.GetComputerTime()
                };
                db.StaffDeductions.Add(staff);
                int re = db.SaveChanges();
                if (re >= 0)
                    MessageBox.Show("Saved...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
