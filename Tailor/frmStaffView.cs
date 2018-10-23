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
    public partial class frmStaffView : Form
    {
        TailorEntities db = new TailorEntities();
        int index = -1;
        int id = 0;

        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            LoadData();

            //disable sort in datagridview 
            foreach (DataGridViewColumn col in dgvList.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //format cell with currency
            dgvList.Columns[6].DefaultCellStyle.Format = "c";
            dgvList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

            LoadInfo();
        }

        public void LoadData()
        {
            var staff = db.Staffs.Where(s => s.IsActive == true).ToList();
            dgvList.Rows.Clear();
            foreach (var s in staff)
            {
                dgvList.Rows.Add(s.Id, s.NameKh, s.Gender.Description, s.DateOfBirth, s.NationalId, s.Phone, s.BasicSalary);
            }
        }

        public void LoadInfo()
        {
            //Count all boy staff in database
            var bStaff = db.Staffs.Where(s => s.GenderId == 1).Where(s => s.IsActive == true).Count();
            lblBoy.Text = bStaff + " នាក់";

            //Count all girl staff in database 
            var gStaff = db.Staffs.Where(s => s.GenderId == 2).Count();
            lblGirl.Text = gStaff + " នាក់";

            //Count all staff in database 
            var staff = db.Staffs.Where(s => s.IsActive == true).Count();
            lblAllStaff.Text = staff + "​​​​​​​​ នាក់";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.staffView = this;
            staff.ShowDialog();
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
            frmStaff staff = new frmStaff();
            staff.staffView = this;
            staff.id = id;
            staff.edit = true;
            staff.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;

            frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
            confirm.label1.Text = "តើអ្នកចង់លុបទិន្នន័យមែនទេ?";
            confirm.btnOkClick = true;
            confirm.ShowDialog();

            if (confirm.btnOkClick)
            {
                try
                {
                    var staff = db.Staffs.Find(id);
                    staff.IsActive = false;
                    int action = db.SaveChanges();
                    {
                        if (action >= 0)
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
            var staff = from s in db.Staffs.ToList()
                        where s.NameKh.Contains(txtSearch.Text.ToLower())
                        where s.IsActive == true
                        select s;
            dgvList.Rows.Clear();
            foreach (var s in staff)
            {
                dgvList.Rows.Add(s.Id, s.NameKh, s.Gender.Description, s.DateOfBirth, s.NationalId, s.Phone, s.BasicSalary);
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnView_Click(sender, e);
        }
    }
}
