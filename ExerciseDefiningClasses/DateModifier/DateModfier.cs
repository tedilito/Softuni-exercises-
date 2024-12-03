
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public  class DateModifier
    {
        public int  CalculateDateDiff(string date1, string date2)
        {
            DateTime fist= DateTime.Parse(date1);
            DateTime second =DateTime.Parse(date2);

            TimeSpan diff = fist - second;
            return Math.Abs(diff.Days);
        }
    }
}
