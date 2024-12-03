using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public class FileAppender : IAppender
    {
        public FileAppender(string pathToFile, ILayout layout)
        {
            this.pathToFile = pathToFile;
            this.layout = layout;
        }

        public string pathToFile { get; set; }
        private readonly ILayout layout;

        public bool Append(string dateTime, ReportLevel report, string message)
        {
            string formatedMessage = this.layout.ReturnLayOutMessage(dateTime, report, message);
            File.AppendAllText(this.pathToFile,formatedMessage );
            return true;
        }
    }
}
