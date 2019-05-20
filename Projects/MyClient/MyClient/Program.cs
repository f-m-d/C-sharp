using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Scrape myScrape = new Scrape();

           string result = myScrape.ScrapeWebPage("https:/msdn.microsoft.com");
        }
    }
}
