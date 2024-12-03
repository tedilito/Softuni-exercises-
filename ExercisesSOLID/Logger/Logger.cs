using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] apenders)
        {
            Apenders = apenders;
        }

        public readonly IAppender[] Apenders;

        public void Log(string dateAndTime, ReportLevel report, string message)
        {
            foreach (var a in Apenders)
            {
                a.Append(dateAndTime, report, message);
            }
        }
    }
}