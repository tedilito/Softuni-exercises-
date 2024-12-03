using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface ILayout
    {
        public string ReturnLayOutMessage(string date, ReportLevel report, string message);

    }
}
