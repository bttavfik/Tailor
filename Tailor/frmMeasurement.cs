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
    public partial class frmMeasurement : Form
    {
        TailorEntities db = new TailorEntities();
        int i;
        public frmMeasurement()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            //to load data in datagridview
            dgvList.Rows.Clear();
            i = 1;
            var measure = db.Measurements.ToList();
            foreach(var m in measure)
            {
                if (m.IsActive == true)
                {
                    dgvList.Rows.Add(i++, m.Id, m.Description);
                }
            }
        }

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.LoadData();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Add(i++, 1, txtDescription.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //to save Measurements
            var measure = new Measurement()
            {
                Description = txtDescription.Text,
                IsActive = true   
            };
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //to remove measurement
            DialogResult dr;
            dr = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int Index = dgvList.CurrentRow.Index;
                int Id = int.Parse(dgvList.Rows[Index].Cells[1].Value.ToString());
                var remove = db.Measurements.Find(Id);
                if (remove != null)
                {
                    remove.IsActive = false;
                    db.SaveChanges();
                    this.LoadData();
                    MessageBox.Show("Removed...");   
                }
            }
        }
    }
}
