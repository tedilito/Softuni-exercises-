using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface ILogger
    {
        void Log(string dateAndTime, ReportLevel report, string message);
     
 
        void Info(string date, string message) => this.Log(date, ReportLevel.Info, message);
        void Warning(string date, string message) => this.Log(date, ReportLevel.Warning, message);
        void Error(string date, string message) => this.Log(date, ReportLevel.Error, message);
        void Critical(string date, string message) => this.Log(date, ReportLevel.Critical, message);
        void Fatal(string date, string message) => this.Log(date, ReportLevel.Fatal , message);
    }
}
