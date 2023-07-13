using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogData
{
    public static class Log
    {
        private static readonly string PathLog = "AppLog.txt";

        public static void WriteLog(string text)
        {
            var logText = $"{DateTime.Now}: {text}\n";
            File.AppendAllText(PathLog, logText);
        }
    }
}