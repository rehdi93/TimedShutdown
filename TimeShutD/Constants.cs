using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShutD
{
    static class AppConstants
    {
        public const int MIN_TIME_SECS = 600;
        public const string OPS_MSG = "Something went wrong...";
        public const int MAX_RECENT_TIMES_COUNT = 10;
    }

    public enum AppStates
    {
        IDLE, SHUT_ACTIVE, SHUT_ABORTED
    }

    public enum Language
    {
        PTBR, ENG
    }
}
