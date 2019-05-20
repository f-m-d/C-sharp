using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProva

{
    enum DayOfWeek : int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }


    class Program
    {

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void HelloFrancesco()
        {
            Console.WriteLine("Hello Francesco!");
        }

        void HelloBoth()
        {
            HelloWorld();
            HelloFrancesco();
        }


        static void SumOut(int a, int b, out int c)
        {
            c = a + b;
        }

        static void SumRef(int a, int b, ref int c)
        {
            c = a + b;
        }

        static void Main(string[] args)
        {
            HelloWorld();
            HelloFrancesco();

            Program p = new Program();
            p.HelloBoth();


            int a = 1;
            int b = 2;
            int c = 0;

            SumOut(a, b, out c);
         

            Console.WriteLine("c out vale: " + c);

            SumRef(500, 600, ref c);

            Console.WriteLine("c ref vale: " + c);
            _ = Console.ReadKey();
        }
    }
}
