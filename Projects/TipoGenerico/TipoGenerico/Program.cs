using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoGenerico
{

    

    class Program
    {


        public static void Swap<T>(ref T a, ref T b) 
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T Max<T>(IEnumerable<T> list) where T : IComparable
        {

            //Ritorna null per gli oggetti, 0 per i numeri
            T valore = default(T);
            return valore;
        
        }



        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;

            Console.WriteLine("Valori di a e b: " + a + ", " + b);

            Swap(ref a, ref b);

            Console.WriteLine("Valori di a e b: " + a + ", " + b);

            _ = Console.ReadKey();


            //NULLABLE: 
        }
    }
}
