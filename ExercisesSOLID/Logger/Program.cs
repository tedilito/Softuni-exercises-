using Logger.Interfaces;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);

            IAppender fileAppender = new FileAppender( @"C:\Users\tedil\OneDrive\Desktop\New Text Document.txt", new XmlLayout());

            ILogger logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");


        }
    }
}
