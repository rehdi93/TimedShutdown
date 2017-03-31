using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShutD
{
    public class Logger
    {
        private const string LOG_FILE_NAME = "log.txt";
        private readonly DateTime _time = DateTime.Now;
        private string _prefix;

        public bool IsActive { get; set; }

        public Logger(bool isActive = false)
        {
            this.IsActive = isActive;
        }

        public void Log(string message)
        {
            if (!IsActive)
                return;

            // place Title on top if file does not exist
            if (!File.Exists(LOG_FILE_NAME))
            {
                using (StreamWriter ft = File.AppendText(LOG_FILE_NAME))
                {
                    var logTitle = $"\n{Consts.LOG_TITLE} - {AppDomain.CurrentDomain.FriendlyName}\n\n";
                    ft.WriteLine(logTitle);
                }
            }

            using (StreamWriter sw = File.AppendText(LOG_FILE_NAME))
            {
                var logLine = $"{_time} - {message}\n";
                sw.WriteLine(logLine);
            }
        }

        private void LogStart()
        {
            //... auto methods for when the app starts and ends?
        }
    }

    static class Consts
    {
        public const string LOG_TITLE = "Red's Logger";
        public const string STOPWATCH = "[STOPWATCH]";
        public const string MENU_CHOICES = "[MENU_CHOICES]";
    }
}
