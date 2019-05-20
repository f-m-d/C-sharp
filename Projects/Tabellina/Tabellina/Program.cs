using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabellina
{
    class Program
    {

        static void Tabellina10(int numero)
        {
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine("" + numero + " * " + i + " = " + numero*i);
            }
        }


        static void Main(string[] args)
        {

            dacapo:
            Console.WriteLine("Inserire il numero della tabellina: ");

            try
            {
                int numero = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La tua tabellina e' : ");
                Tabellina10(numero);
            }

            catch (FormatException)
            {
                Console.WriteLine("Non hai inserito un numero.");
                goto dacapo;
            }

            catch (OverflowException)
            {
                Console.WriteLine("Il numero inserito e' troppo grande.");
                goto dacapo;
            }


            _ = Console.ReadKey();
        }
    }

    }
}
