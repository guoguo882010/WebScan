using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MadMilkman.Ini;

namespace GK.WebScan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new file with a default formatting.
            IniFile file = new IniFile();

            // Add new section.
            IniSection section = file.Sections.Add("Section name");
            // Add trailing comment.
            section.TrailingComment.Text = "Section trailing comment";

            // Add new key and its value.
            IniKey key = section.Keys.Add("Key name", "Key value ");
            // Add leading comment.
            key.LeadingComment.Text = "Key leading comment";

            // Save file.
            file.Save("Sample.ini");

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
