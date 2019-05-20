using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDelegates
{
    class Program
    {
        delegate string SampleDelegate(string s);

        public static string LongEcho(string s)
        {
            Thread.Sleep(2000);
            return "Hello " + s;
        }

        static void Main(string[] args)
        {

            //MODO SINCRONO, UNO SUCCESSIVO ALL'ALTRO

            var echoDelegate = new SampleDelegate(LongEcho);

            Console.WriteLine(echoDelegate("Marco 1"));
            Console.WriteLine(echoDelegate("Luca 2"));
            Console.WriteLine(echoDelegate("Antonio 3"));

            _ = Console.ReadKey();



            var echoDelegateAsync = new SampleDelegate(LongEcho);

            var results = new List<IAsyncResult>();

            results.Add(echoDelegateAsync.BeginInvoke("Marco 1", null, null));
            results.Add(echoDelegateAsync.BeginInvoke("Luca 2", null, null));
            results.Add(echoDelegateAsync.BeginInvoke("Antonio 3", null, null));


            foreach (IAsyncResult result in results)
            {
                Console.WriteLine(echoDelegateAsync.EndInvoke(result));
            }


            _ = Console.ReadKey();
        }
    }
}
