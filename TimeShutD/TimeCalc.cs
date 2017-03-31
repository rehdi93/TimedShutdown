using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShutD
{
    public class TimeCalc
    {

        public int Hrs { get; set; }
        public int Min { get; set; }

        public int TotalSecs
        {
            get => (int)_formatedTime().TotalSeconds;
        }
        public string FullTime
        {
            get => _formatedTime().ToString();
        }

        private TimeSpan _formatedTime()
        {
            return new TimeSpan(this.Hrs, this.Min, 0);
        }

    }

}
