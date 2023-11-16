namespace ConsoleApp7
{
    using System;

    public interface ILogger
    {
        void Log(string message);
    }

    public class Program
    {
        public static void Main()
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Message");
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log("This is the last message");
        }
    }

    public partial class FileLogger : ILogger
    {
        public void Log(string message)
        {
            System.IO.File.WriteAllText("log.txt", message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logs in Database");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            this._logger = logger;
        }

        public void ProcessData()
        {
            try
            {
                Console.WriteLine("Do nothing");
            }
            catch (Exception ex)
            {
                this._logger.Log(ex.Message);
            }
        }
    }
}
