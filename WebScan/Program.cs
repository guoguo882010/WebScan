using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GK.WebScan
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy(@"C:\Users\guogu\Desktop\1.txt",true);

            while (true)
            {
                var proxies = proxy.ProxyList;
                for (int i = 0; i < proxies.Count; i++)
                {
                    Console.WriteLine(proxies[i]);
                }
                Thread.Sleep(3000);
            }
            
            
            //Console.ReadLine();
        }
    }
}
