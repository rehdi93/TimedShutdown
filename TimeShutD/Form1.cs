using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeShutD
{
    public partial class TimeShut : Form
    {
        private TimeCalc _tc = new TimeCalc();
        private AppConfig _appConfig = new AppConfig();
        System.Resources.ResourceManager resMan;
        System.Globalization.CultureInfo cul;

        //UiController _ui = new UiController();

        public TimeShut()
        {
            InitializeComponent();

            if (!System.IO.File.Exists(AppConfig.File))
            {
                MessageBox.Show($"{AppConfig.File} not found, using defaults.");
                AppConfig.Default().Save<AppConfig>();
            }
            
            _appConfig = XmlFunc.Load<AppConfig>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UiUpdate();
        }

        private void bntShutdown_Click(object sender, EventArgs e)
        {
            _tc.Hrs = (int)numHrs.Value;
            _tc.Min = (int)numMin.Value;

            ShutCom(_tc.TotalSecs);
        }

        private void bntAbort_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            p.StartInfo.FileName = "Shutdown";
            p.StartInfo.Arguments = "-a";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;
            p.Exited += OnAbortComSent;

            var response = MessageBox.Show("Abort sheduled shutdown?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (response)
            {
                case DialogResult.Yes:
                    p.Start();
                    break;
                case DialogResult.No:
                    //... do nothing
                    break;
                default:
                    MessageBox.Show(AppConstants.OPS_MSG);
                    break;
            }
            //Process.Start("Shutdown", "-a");
        }

        private void OnAbortComSent(object sender, EventArgs e)
        {
            _appConfig.ShutdownState = AppStates.SHUT_ABORTED;
            UiUpdate();
        }

        private void ShutCom(int seconds)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Shutdown";
            p.StartInfo.Arguments = $"-s -t {seconds}";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;
            p.Exited += OnShutComSent;

            var warnLittleTime = (seconds < AppConstants.MIN_TIME_SECS);

            string message = warnLittleTime ? $"You've set a small amount of time before the PC turns off ({_tc.FullTime})\n" + 
                "Make sure you have time to save all your work before confirming!\n\n" + "Schedule shutdown?"
                : $"Schedule shutdown? Pc will turn off in {_tc.FullTime}";

            string caption = warnLittleTime ? "Warning!" : "";
            var icon = warnLittleTime ? MessageBoxIcon.Warning : MessageBoxIcon.Information;

            var response = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, icon);

            switch (response)
            {
                case DialogResult.Yes:
                case DialogResult.OK:
                    p.Start();
                    break;
                case DialogResult.No:
                case DialogResult.Cancel:
                    // ...
                    break;
                default:
                    MessageBox.Show(AppConstants.OPS_MSG);
                    break;
            }

        }

        private void OnShutComSent(object sender, EventArgs e)
        {
            _appConfig.ShutdownState = AppStates.SHUT_ACTIVE;
            _appConfig.AddRecentTime(_tc.FullTime);
            UiUpdate();
        }

        private void UiUpdate()
        {

            switch (_appConfig.ShutdownState)
            {
                case AppStates.IDLE:
                case AppStates.SHUT_ABORTED:
                    bntAbort.Enabled = false;
                    bntShutdown.Enabled = true;
                    InfoLabel.Text = "Idle";
                    break;
                case AppStates.SHUT_ACTIVE:
                    InfoLabel.Text = "Shutdown in process...";
                    bntAbort.Enabled = true;
                    bntShutdown.Enabled = false;
                    break;
                default:
                    MessageBox.Show(AppConstants.OPS_MSG);
                    break;
            }
            // refresh list
            recentTimesBox.Items.Clear();
            recentTimesBox.Items.AddRange(_appConfig.RecentTimes.ToArray());

            if (_appConfig.RecentTimes.Count > 0)
                recentTimesBox.SelectedItem = _appConfig.RecentTimes[0];

        }

        private void TimeShut_FormClosing(object sender, FormClosingEventArgs e)
        {
            _appConfig.Save<AppConfig>();
        }

        private void recentTimesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string boxItem = (sender as ComboBox).SelectedItem.ToString();
            var converted = new List<decimal>();
            //bool res = decimal.TryParse(boxItem, )

            string[] vals = boxItem.Split(':');

            foreach (var s in vals)
            {
                if (int.TryParse(s, out int num))
                    converted.Add(num);
            }

            numHrs.Value = converted[0];
            numMin.Value = converted[1];
        }
    }
}
