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
    public partial class frmStaffDeductionView : Form
    {
        
        
        public frmStaffDeductionView()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            //Load Staff Deduction
            dgvList.Rows.Clear();
            int i = 1;
            using (var context = new TailorEntities())
            {
                var staff = context.StaffDeductions.ToList();

                foreach (var s in staff)
                {
                    dgvList.Rows.Add(i++, s.StaffCode, s.Staff.NameKh, s.Date, s.Amount, s.Reason);
                }
            }
        }

        private void frmStaffDeductionView_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //call form staff deduction
            frmStaffDeduction frm = new frmStaffDeduction();
            frm.ShowDialog();
            this.LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //sarche staff deduction
            dgvList.Rows.Clear();
            int i = 1;
            using (var context = new TailorEntities())
            {
                var result = from s in context.StaffDeductions.ToList() where s.Staff.NameKh.ToLower().StartsWith(txtSearch.Text.ToLower()) select s;
                foreach (var s in result)
                {
                    dgvList.Rows.Add(i++, s.StaffCode, s.Staff.NameKh, s.Date, s.Amount, s.Reason);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int Index = dgvList.CurrentRow.Index;
                    int Id = int.Parse(dgvList.Rows[Index].Cells[1].Value.ToString());
                    using (var context = new TailorEntities())
                    {
                        var remove = context.StaffDeductions.Find(Id);
                        if (remove != null)
                        {
                            //remove.Status = false;
                            context.SaveChanges();
                            this.LoadData();
                            MessageBox.Show("Removed...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no value to delete");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //to load form staff deduction and update
            int Index = dgvList.CurrentRow.Index;
            if (Index >= 0)
            {
                int Id = int.Parse(dgvList.Rows[Index].Cells[1].Value.ToString());
                frmStaffDeduction frm = new frmStaffDeduction();
                frm.editId = Id;
                frm.editFlag = true;
                frm.ShowDialog();
                this.LoadData();
            }          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
