using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GK.WebScan
{
    class Proxy
    {
        private List<string> _proxyList = new List<string>();
        private Timer _timer = new Timer();
        private string _proxyFile;

        public List<string> ProxyList { get { return _proxyList; } }

        public Proxy(string file,bool isTimerEnable = false,double timerInterval = 60000)
        {
            _proxyFile = file ?? throw new ArgumentNullException(nameof(file));
            if (isTimerEnable)
            {
                _timer.Interval = timerInterval;
                _timer.Elapsed += GetProxy;
                _timer.Enabled = isTimerEnable;
            }
            else
            {
                GetProxy();
            }
            
        }

        private void GetProxy(object o, EventArgs e)
        {
            GetProxy();
        }

        private void GetProxy()
        {
            string line = String.Empty;
            _proxyList.Clear();
            using (StreamReader sr = new StreamReader(_proxyFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    _proxyList.Add(line);
                }
            }
        }

        public string GetRandom()
        {
            Random rnd = new Random();
            int r = rnd.Next(_proxyList.Count);
            return _proxyList[r];
        }

        public void TimerStart()
        {
            _timer.Start();
        }

        public void TimerStop()
        {
            _timer.Stop();
        }

    }
}
