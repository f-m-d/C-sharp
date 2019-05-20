using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    class Program
    {

        public static int Division(int a, int b)
        {
            try
            {
                int result = a / b;

                //Codice che non verra' eseguito in caso di errore
                Console.WriteLine("Risultato calcolato con successo");
                return result;
            }
            catch (DivideByZeroException)
            {
                
                Console.WriteLine("Hai provato a dividere per zero.");
            }

            return 0;
           
        }

        static void Main(string[] args)
        {

            var result = Division(5 , 0);

            //Codice mai eseguito
            Console.WriteLine("Ho diviso per zero");
        }
    }
}
