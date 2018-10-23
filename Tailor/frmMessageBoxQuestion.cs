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
    public partial class frmMessageBoxQuestion : Form
    {
        public frmMessageBoxQuestion()
        {
            InitializeComponent();
        }

        public bool btnOkClick;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOkClick = true;
            this.Close();
        }

        private void frmMessageBoxQuestion_Load(object sender, EventArgs e)
        {
            btnOkClick = false;
        }
    }
}
