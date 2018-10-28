using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailor.Entities
{
    class TailorSetting
    {
        public static DateTime GetComputerTime()
        {
            return DateTime.Now;
        }

        public static string GetComputerCode()
        {
            return Properties.Settings.Default.ComputerCode;
        }

        public static void GenerateRowNumber(DataGridView dgvList)
        {
            int no = 1;
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                dgvList.Rows[i].Cells[0].Value = (no++);
            }
        }
    }
}
