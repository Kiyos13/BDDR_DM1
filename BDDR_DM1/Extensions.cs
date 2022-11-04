using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDR_DM1
{
    public static class Extensions
    {
        public static string Display(this DateTime date)
        {
            string str = "'" + date.Day + "-" + date.Month + "-" + date.Year + "'";
            return str;
        }

        public static string ToSqlYear(this int year)
        {
            string str = "TO_DATE('" + year + "', 'YYYY')";
            return str;
        }
    }
}
