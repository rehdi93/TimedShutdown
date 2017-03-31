using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeShutD
{
    public class UiController
    {

        private AppStates _defaultMode;
        private AppStates _currentMode;

        public UiController()
        {
            this._defaultMode = AppStates.IDLE;
        }

        public UiController(AppStates mode) : this()
        {
            var isValid = Enum.IsDefined(typeof(AppStates), mode);
            if (isValid)
                this._currentMode = mode;
            else
                throw new ArgumentException("Mode must be a valid state", mode.ToString());
        }

        public string CurrentMode
        {
            get
            {
                if (String.IsNullOrEmpty(CurrentMode))
                    return _defaultMode.ToString();
                else
                    return _currentMode.ToString();
            }
        }
       
        //public void UiUpdate()
        //{
        //    var mode = this.CurrentMode;

        //    switch (mode)
        //    {
        //        case AppStates.IDLE:
                    
        //        default:
        //            break;
        //    }
        //}

    }
}
