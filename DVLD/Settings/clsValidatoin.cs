using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsValidatoin
    {
        // ✅ تحقق من الإيميل
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }

        // ✅ تحقق من عدد صحيح
        public static bool ValidateInteger(string number)
        {
            int result;
            return int.TryParse(number, out result);
        }

        // ✅ تحقق من عدد عشري (Float)
        public static bool ValidateFloat(string number)
        {
            float result;
            return float.TryParse(number, out result);
        }

        // ✅ تحقق من رقم (أي نوع: int أو float أو double)
        public static bool ValidateNumber(string number)
        {
            double result;
            return double.TryParse(number, out result);
        }
       
    }
}
