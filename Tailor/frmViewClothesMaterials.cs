using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailor
{
    public partial class frmViewClothesMaterials : Form
    {
        public frmViewClothesMaterials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClothesMaterials ClothesMaterials = new frmClothesMaterials();
            ClothesMaterials.Show();
        }
    }
}
