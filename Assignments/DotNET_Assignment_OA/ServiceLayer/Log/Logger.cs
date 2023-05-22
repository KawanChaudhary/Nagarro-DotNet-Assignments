using ServiceLayer.Log;
using System;
using System.IO;
using System.Text;

namespace ServiceLayer.Logger
{
    public sealed class Logger : ILogger
    {
        private Logger()
        {
        }
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        public static Logger GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogDetails(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Log", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }

    }
}
