using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Helpers
{
    public static class LoggerHelper
    {
        public static void LogFile(Exception ex, string function)
        {
            DateTime date = DateTime.Now;
            string path = "C:\\Logs\\RapNacionalAPILogs.txt";
            string logFormat = "FUNCTION: {0} | DATA: {1} | EXCEPTION: {2}{3}";
            System.IO.File.AppendAllText(path, String.Format(logFormat, function, date, ex.Message.ToString(), Environment.NewLine));
        }

        public static void LogSerilog(Exception ex, string function)
        {

        }
    }
}

