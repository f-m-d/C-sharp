using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Scrape
    {

        public string ScrapeWebPage(string url)
        {


            return GetWebPage(url);

  
        }

        public string ScrapeWebPage(string url, string filepath)
        {

            string reply = GetWebPage(url);

            System.IO.File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
