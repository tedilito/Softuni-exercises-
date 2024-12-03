using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout typeOfLayout)
        {
            this.typeOfLayout = typeOfLayout ?? throw new ArgumentNullException($"Enter value for {nameof(typeOfLayout)}");
        }

        public ILayout typeOfLayout { get; set; }

        public bool Append(string dateTime, ReportLevel repoer, string message)
        {
            string formatedMessage = this.typeOfLayout.ReturnLayOutMessage(dateTime, repoer, message);
            Console.WriteLine(formatedMessage);
            return true;
        }
    }
}
