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
    public partial class frmTailorMessage : Form
    {
        public string MessageText { get; set; }
        public string MessageCaption { get; set; }
        public Image MessageIcon { get; set; }

        public frmTailorMessage()
        {
            InitializeComponent();
        }

        private void frmTailorMessage_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.pcbMessageIcon.Image = MessageIcon;
            this.lblMessageText.Text = MessageText;
            this.Text = MessageCaption;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
