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
    public partial class frmStaffPermissionView : Form
    {

        TailorEntities db = new TailorEntities();
        int index = -1;
        int id = 0;

        public frmStaffPermissionView()
        {
            InitializeComponent();
        }

        private void frmStaffPermissionView_Load(object sender, EventArgs e)
        {
            LoadData();

            foreach (DataGridViewColumn col in dgvList.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Format date in datagridview
            dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void LoadData()
        {
            try
            {
                var permission = db.StaffPermissions.ToList();
                dgvList.Rows.Clear();
                foreach (var staff in permission)
                {
                    dgvList.Rows.Add(staff.StaffId, staff.Staff.NameKh, staff.FromDate, staff.UntilDate, staff.Reason);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStaffPermission staff = new frmStaffPermission();
            staff.StaffPermissionView = this;
            staff.ShowDialog();
            LoadData();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvList.CurrentRow.Index;
            if (index >= 0)
            {
                id = Convert.ToInt32(dgvList.Rows[index].Cells[0].Value.ToString());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            frmStaffPermission staff = new frmStaffPermission();
            staff.id = id;
            staff.edit = true;
            staff.StaffPermissionView = this;
            staff.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
            confirm.label1.Text = "តើអ្នកចង់លុបទិន្នន័យមែនទេ?";
            confirm.ShowDialog();
            if (confirm.btnOkClick)
            {
                try
                {
                    var staff = db.StaffPermissions.SingleOrDefault(s => s.StaffId == id);
                    if (staff != null)
                    {
                        db.StaffPermissions.Remove(staff);
                        int action = db.SaveChanges();
                        if (action >= 1)
                        {
                            LoadData();
                            frmMessageBoxSuccessfull message = new frmMessageBoxSuccessfull();
                            message.ShowDialog();
                        }
                    }
                }
                catch (Exception exc)
                {
                    frmMessageBoxFail message = new frmMessageBoxFail();
                    message.ShowDialog();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked && chkName.Checked)
            {
                try
                {
                    var staff = db.StaffPermissions.Where(s => s.FromDate >= dtpFromDate.Value)
                        .Where(s => s.FromDate <= dtpUntillDate.Value)
                        .Where(s => s.Staff.NameKh.Contains(txtSearch.Text.Trim().ToLower())).ToList();
                    dgvList.Rows.Clear();
                    foreach (var s in staff)
                    {
                        dgvList.Rows.Add(s.StaffId, s.Staff.NameKh, s.FromDate, s.UntilDate, s.Reason);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (chkName.Checked && chkDate.Checked == false)
            {
                try
                {
                    var staff = db.StaffPermissions.Where(s => s.Staff.NameEn.Contains(txtSearch.Text.Trim().ToLower())).ToList();
                    dgvList.Rows.Clear();
                    foreach (var s in staff)
                    {
                        dgvList.Rows.Add(s.StaffId, s.Staff.NameKh, s.FromDate, s.UntilDate, s.Reason);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                LoadData();
            }
        }

        private void dtpUntillDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked && chkName.Checked == false)
            {
                try
                {
                    var staff = db.StaffPermissions.Where(s => s.FromDate >= dtpFromDate.Value)
                        .Where(s => s.FromDate <= dtpUntillDate.Value).ToList();
                    dgvList.Rows.Clear();
                    foreach (var s in staff)
                    {
                        dgvList.Rows.Add(s.StaffId, s.Staff.NameKh, s.FromDate, s.UntilDate, s.Reason);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpUntillDate_ValueChanged(sender, e);
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnView_Click(sender, e);
        }
    }
}
