using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
