using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class Esteso
    {

        public static Boolean isNullato(this string value) => value == null;
    }

    class Program
    {
        static void Main(string[] args)
        {

            string stringaVuota = null;
            string stringaCiao = "Ciao";

            Console.WriteLine("Il metodo ritorna per la stringa vuota: " + stringaVuota.isNullato());
            Console.WriteLine("l metodo ritorna per la stringa CIAO: " + stringaCiao.isNullato());
            char c = Console.ReadKey().KeyChar;

            Console.WriteLine("l metodo ritorna per la lettera inserita: " + c);

            _ = Console.ReadKey();
        }
    }
}
