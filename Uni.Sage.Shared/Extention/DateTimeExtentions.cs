using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Shared.Extention
{
    public static class DateTimeExtentions
    {

        public static DateTime MinGregorianDate(this DateTime date)
        {
            return new DateTime(1753,1,1);

        }

        public static DateTime OnlyDate(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);

        }
    }
}
