using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloYourName
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASKS FOR YOUR NAME
            Console.WriteLine("Hello foreigner, what is your name?\n");

            //INPUT YOUR NAME
            string yourName= Console.ReadLine();

            //PRINT OUT YOUR NAME
            Console.WriteLine("Hello, " + yourName);
            _ = Console.ReadKey();
        }
    }
}
