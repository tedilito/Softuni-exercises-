using Logger.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class XmlLayout : ILayout
    {
        public string ReturnLayOutMessage(string date, ReportLevel report, string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine("   <date>{ dateAndTime}</ date > ");
            sb.AppendLine("  <level>{ reportLevel}</ level > ");
            sb.AppendLine("  <message>{ message}</ message > ");
            sb.Append("</log>");

            return sb.ToString();
        }
    }
}
