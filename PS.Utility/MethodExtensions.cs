using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Utility
{
    public static class MethodExtensions
    {
        public static bool Between(this DateTime dateTime, DateTime startDate, DateTime endDate)
        {
            return dateTime >= startDate && dateTime <= endDate;
        }
    }
}
