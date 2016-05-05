using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class FormatHelper
    {
        public static bool IsInteger(string str)
        {
            int number;
            return int.TryParse(str, out number);
        }

        public static bool IsDecimal(string str)
        {
            decimal number;
            return decimal.TryParse(str, out number);
        }

        public static bool ValidateProbabity(string str)
        {
            double number;
            return double.TryParse(str, out number) && number >= 0 && number <= 1;
        }
    }
}
