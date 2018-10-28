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
    public partial class frmStaffPermission : Form
    {
        TailorEntities db = new TailorEntities();
        //public frmStaffPermissionView StaffPermissionView = null;
        public int id = 0;
        public bool edit = false;

        public frmStaffPermission()
        {
            InitializeComponent();
        }

        private void frmStaffPermission_Load(object sender, EventArgs e)
        {
            //Load staff from database
            var staff = db.Staffs.Where(s => s.IsActive == true).ToList();
            cboStaff.DataSource = staff;
            cboStaff.DisplayMember = "NameKh";
            cboStaff.ValueMember = "Id";

            //ComboBox defualt selection
            cboStaff.SelectedIndex = -1;

            if (edit)
            {
                //var s = db.StaffPermissions.Find(id);
                //cboStaff.SelectedValue = s.StaffId;
                //dtpFromDate.Value = s.FromDate;
                //dtpUntillDate.Value = s.UntilDate;
                //txtReason.Text = s.Reason;
                //btnSave.Text = "កែប្រែ";
                //btnCancel.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStaff.SelectedIndex < 0)
            {
                MessageBox.Show("Please select name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStaff.Focus();
                return;
            }

            if (dtpFromDate.Value == null)
            {
                MessageBox.Show("Please choose date...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFromDate.Focus();
                SendKeys.Send("{%DOWN}");
                return;
            }

            if (dtpUntillDate.Value == null)
            {
                MessageBox.Show("Please choose date...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFromDate.Focus();
                SendKeys.Send("{%DOWN}");
                return;
            }

            if (string.IsNullOrEmpty(txtReason.Text.Trim()))
            {
                MessageBox.Show("Please write the reason...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReason.Focus();
                return;
            }

            //if (edit)
            //{
            //    try
                //{
                //    frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
                //    confirm.label1.Text = "តើអ្នកចង់កែប្រែទិន្នន័យមែនទេ?";
                //    confirm.btnOkClick = true;
                //    confirm.ShowDialog();

                //    if (confirm.btnOkClick)
                //    {
                //        //var s = db.StaffPermissions.Find(id);
                //        //s.FromDate = dtpFromDate.Value;
                //        //s.UntilDate = dtpUntillDate.Value;
                //        //s.Reason = txtReason.Text;
                //        //s.ComputerCode = Convert.ToInt32(Entities.TailorSetting.GetComputerCode());
                //        //s.ComputeTime = Entities.TailorSetting.GetComputerTime();
                //        //int action = db.SaveChanges();
                //        //this.Close();
                //        //if (action >= 1)
                //        //{
                //        //    if (StaffPermissionView != null)
                //        //    {
                //        //        StaffPermissionView.LoadData();
                //        //    }
                //        //    frmMessageBoxSuccessfull message = new frmMessageBoxSuccessfull();
                //        //    message.ShowDialog();
                //        //}
                //    }
                //}
                //catch (Exception)
                //{
                //    frmMessageBoxFail message = new frmMessageBoxFail();
                //    message.ShowDialog();
                //}
            //}
            //else
            //{
                //try
                //{
                //    frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
                //    confirm.label1.Text = "តើអ្នកចង់រក្សាទុក្ខទិន្នន័យមែនទេ?";
                //    confirm.btnOkClick = true;
                //    confirm.ShowDialog();

                //    if (confirm.btnOkClick)
                //    {
                //        //StaffPermission staff = new StaffPermission()
                //        //{
                //        //    StaffId = Convert.ToInt32(cboStaff.SelectedValue.ToString()),
                //        //    FromDate = dtpFromDate.Value,
                //        //    UntilDate = dtpUntillDate.Value,
                //        //    Reason = txtReason.Text,
                //        //    ComputerCode = Convert.ToInt32(Entities.TailorSetting.GetComputerCode()),
                //        //    ComputeTime = Entities.TailorSetting.GetComputerTime()
                //        //};
                //        //db.StaffPermissions.Add(staff);
                //        //int action = db.SaveChanges();
                //        //if (action >= 1)
                //        //{
                //        //    ClearData();
                //        //    if (StaffPermissionView != null)
                //        //    {
                //        //        StaffPermissionView.LoadData();
                //        //    }
                //        //    frmMessageBoxSuccessfull message = new frmMessageBoxSuccessfull();
                //        //    message.ShowDialog();
                //        //}
                //    }
                //}
                //catch (Exception)
                //{
                //    frmMessageBoxFail message = new frmMessageBoxFail();
                //    message.ShowDialog();
                //}
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            cboStaff.SelectedIndex = -1;
            dtpFromDate.Value = DateTime.Now;
            dtpUntillDate.Value = DateTime.Now;
            txtReason.Text = "";
            cboStaff.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
