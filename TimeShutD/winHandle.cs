using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TimeShutD
{
    public class winHandle
    {
        private static int WM_QUERYENDSESSION = 0x11;
        private bool sysShutdown = false;
    }
}
