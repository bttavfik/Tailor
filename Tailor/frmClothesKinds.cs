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
    public partial class frmClothesKinds : Form
    {
        TailorEntities db = new TailorEntities();
        int i;
        public frmClothesKinds()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            //Load clothes Kind
            dgvList.Rows.Clear();
            i = 1;
            var clothes = db.ClothesKinds.ToList();
            foreach (var c in clothes)
            {
                dgvList.Rows.Add(i++, c.Id, c.Description);
            }
            //dgvList.Rows.Clear();
            //var c = db.ClothesKinds.ToList();
            //foreach (var clothes in c)
            //{
            //    dgvList.Rows.Add(i++, clothes.Id, clothes.Description);
            //}
        }
       
        private void frmClothesKinds_Load(object sender, EventArgs e)
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
            
            //Add clothes Kinds
            dgvList.Rows.Add(i++, 1, txtDescription.Text);
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
            //Save clothes Kind
            var clothes = new ClothesKind()
            {
               Description=txtDescription.Text
            };
            db.ClothesKinds.Add(clothes);
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
            //delet clothes Kinds
            DialogResult dr;
            dr = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int Index = dgvList.CurrentRow.Index;
                int Id = int.Parse(dgvList.Rows[Index].Cells[1].Value.ToString());
                var delete = db.ClothesKinds.SingleOrDefault(x => x.Id == Id);
                if (delete != null)
                {
                    db.ClothesKinds.Remove(delete);
                    db.SaveChanges();
                    this.LoadData();
                    MessageBox.Show("Delete...");
                }
            }
        }
    }
}
