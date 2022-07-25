using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log : ILog
    {

        private Log()
        { }

        private static readonly Lazy<Log> logInstance = new Lazy<Log>(()=> new Log());

        public static Log GetInstance
        {
            get
            {
                return logInstance.Value;
            }
        }

        public void LogException(string messsge)
        {
            string fileName = string.Format("{0}.log", "Exception");
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory + @"\ErrorLog", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(messsge);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
