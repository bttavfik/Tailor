using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailor.Services
{
    class TailorMessage
    {
        public static DialogResult Show(string message = "", string caption = "", Image icon = null)
        {
            frmTailorMessage tailorMessage = new frmTailorMessage();
            tailorMessage.MessageText = message;
            tailorMessage.MessageCaption = caption;
            tailorMessage.MessageIcon = icon;
            return tailorMessage.ShowDialog();
        }
    }
}
