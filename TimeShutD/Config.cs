using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeShutD
{
    [Serializable]
    public class AppConfig : XmlFunc
    {
        private List<string> _recentTimes = new List<string>(10);
        private Language? _activeLang;

        public static readonly string File = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSDConfig.xml");

        public AppStates ShutdownState { get; set; }
        public List<string> RecentTimes { get => _recentTimes; private set => _recentTimes = value; }
        public Language ActiveLang
        {
            get =>  _activeLang.GetValueOrDefault(Language.ENG);
            set => _activeLang = value;
        }

        public string Title = "TSD Configuration file";

        public void AddRecentTime(string time)
        {
            if (string.IsNullOrWhiteSpace(time))
                throw new ArgumentNullException(time);

            // avoid duplicates
            if (RecentTimes.Contains(time))
                RecentTimes.Remove(time);

            // delete last if capacity is reached
            if (RecentTimes.Count == RecentTimes.Capacity)
                RecentTimes.RemoveAt(RecentTimes.Capacity - 1);

            RecentTimes.Insert(0, time);
        }

        public void ClearRecentTimes()
        {
            RecentTimes.Clear();
        }

        public static AppConfig Default()
        {
            var a = new AppConfig()
            {
                ShutdownState = AppStates.IDLE,
                RecentTimes = new List<string>(10),
                //Title = "Default settings"
            };
            return a;
        }
    }

    public class XmlFunc
    {
        public static T Load<T>(string fileName = null) where T : XmlFunc, new()
        {
            if (String.IsNullOrWhiteSpace(fileName))
                fileName = AppConfig.File;

            //if (!File.Exists(fileName))
            //    return;

            T result = default(T);

            using (FileStream stream = File.OpenRead(fileName))
                result = new XmlSerializer(typeof(T)).Deserialize(stream) as T;

            return result;
        }

        public void Save<T>(string fileName = null) where T : XmlFunc
        {
            if (String.IsNullOrWhiteSpace(fileName))
                fileName = AppConfig.File;

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
                new XmlSerializer(typeof(T)).Serialize(stream, this);
        }
    }
}
