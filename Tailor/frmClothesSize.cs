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
    public partial class frmClothesSize : Form
    {
        TailorEntities db = new TailorEntities();
        int i;
        public frmClothesSize()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            //Load clothes Size
            //dgvList.Rows.Clear();
            //i = 1;
            //var clothes = db.ClothesSizes.ToList();
            //foreach(var c in clothes)
            //{
            //    if (c.IsActive == true)
            //    {
            //        dgvList.Rows.Add(i++, c.Id, c.Size);
            //    }
            //};
        }
       
        private void frmClothesSize_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //description can't be null
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Input description...");
                txtDescription.Focus();
                return;
            }
            //add to clothes size
            dgvList.Rows.Add(i++,1,txtDescription.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //description can't be null
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Input description...");
                txtDescription.Focus();
                return;
            }
            //to save clothes size
            var clothes = new ClothesSize()
            {
                Size=txtDescription.Text,
                IsActive=true
            };
            db.ClothesSizes.Add(clothes);
            db.SaveChanges();
            this.LoadData();
            MessageBox.Show("Saved...");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Index = dgvList.CurrentRow.Index;
            int Id = int.Parse(dgvList.Rows[Index].Cells[1].Value.ToString());
            var remove = db.ClothesSizes.Find(Id);
            if (remove != null)
            {
                remove.IsActive = false;
                dgvList.Rows.Add(i++, remove.Id, remove.Size);
                db.SaveChanges();
                this.LoadData();
                MessageBox.Show("Removed..");
            }
        }
    }
}
