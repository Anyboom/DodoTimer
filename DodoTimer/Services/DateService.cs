using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodoTimer.Services
{
    class DateService
    {
        public static bool CheckDate(DateTime x)
        {
            return x.Day == DateTime.Now.Day && x.Year == DateTime.Now.Year && x.Month == DateTime.Now.Month;
        }
    }
}
