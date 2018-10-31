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
    public partial class frmStaffView : Form
    {
        int index = -1;
        string code = "";

        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadInfo();
        }

        public void LoadData()
        {
            using (var context = new TailorEntities())
            {
                var query = context.Staffs.Where(s => s.IsActive).ToList();
                dgvList.Rows.Clear();
                foreach (var s in query)
                {
                    dgvList.Rows.Add("",s.Code, s.NameKh, s.Gender.Description, s.DateOfBirth, s.NationalId, s.Phone, s.BasicSalary);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
            //disable sort in datagridview 
            foreach (DataGridViewColumn col in dgvList.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //format cell with currency
            dgvList.Columns[7].DefaultCellStyle.Format = "c";
            dgvList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void LoadInfo()
        {
            using (var context = new TailorEntities())
            {
                //Count all boy staff in database
                var bStaff = context.Staffs.Where(s => s.GenderId == 1 && s.IsActive).Count();
                lblBoy.Text = bStaff + " នាក់";

                //Count all girl staff in database 
                var gStaff = context.Staffs.Where(s => s.GenderId == 2 && s.IsActive).Count();
                lblGirl.Text = gStaff + " នាក់";

                //Count all staff in database 
                var staff = context.Staffs.Where(s => s.IsActive).Count();
                lblAllStaff.Text = staff + "​​​​​​​​ នាក់";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.staffView = this;
            staff.ShowDialog();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (dgvList.RowCount > 0)
            {
                if (index < 0)
                    return;
                code = dgvList.Rows[index].Cells[1].Value.ToString();
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            frmStaff staff = new frmStaff();
            staff.staffView = this;
            staff.edit = true;
            staff.code = code;
            staff.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            DialogResult dr = TailorMessage.Show("តើអ្នកចង់លុបទិន្នន័យមែនទេ?", "លុបទិន្នន័យ", TailorMessageIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (var context = new TailorEntities())
                {
                    var staff = context.Staffs.SingleOrDefault(s => s.Code == code);
                    staff.IsActive = false;
                    int action = context.SaveChanges();
                    {
                        if (action >= 1)
                        {
                            LoadData();
                            LoadInfo();
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new TailorEntities())
            {
                var query = context.Staffs.ToList().Where(s => s.NameKh.Contains(txtSearch.Text.Trim()) || s.Code.ToLower().Contains(txtSearch.Text.Trim().ToLower()) && s.IsActive);
                dgvList.Rows.Clear();
                foreach (var s in query)
                {
                    dgvList.Rows.Add("", s.Code, s.NameKh, s.Gender.Description, s.DateOfBirth, s.NationalId, s.Phone, s.BasicSalary);
                }
                TailorService.GenerateRowNumber(dgvList);
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnView_Click(sender, e);
        }
    }
}
