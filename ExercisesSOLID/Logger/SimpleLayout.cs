using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class SimpleLayout : ILayout
    {
        public string ReturnLayOutMessage(string date, ReportLevel report, string message)
        {
            return $"{date} - {report} - {message}";
        }
    }
}
