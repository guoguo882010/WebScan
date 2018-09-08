using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GK.WebScan
{
    class Urls
    {
        private List<string> _urls = new List<string>();
        private string _filePath;

        public Urls(string filepath)
        {
            _filePath = filepath ?? throw new ArgumentNullException(nameof(filepath));
        }

        public List<string> GetUrls()
        {
            string line = String.Empty;
            _urls.Clear();
            using (StreamReader sr = new StreamReader(_filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    _urls.Add(line);
                }
            }
            return _urls;
        }
    }
}
