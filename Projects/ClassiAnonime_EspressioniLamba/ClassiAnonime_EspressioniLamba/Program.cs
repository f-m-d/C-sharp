using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAnonime_EspressioniLamba
{
    class Program
    {


        static void Main(string[] args)
        {
            var strings = new List<string>();


            //AL POSTO DI UN PREDICATE, PASSO UN METODO ANONIMO DELEGATO
            // CON IN INPUT UNA STRING S E RITORNA UN BOOLEANO

            // METODO ANONIMO
            var foundString = strings.Find(
                delegate (string s)
                {
                    return s.Contains("a");
                });

            // ESPRESSIONE LAMBDA: INSTANZIA UN DELEGATE 
            // FA ESATTAMENTE QUELLO CHE FA L'ESPRESSIONE SOPRA
            var foundStringLambda = strings.Find(i => i.Contains("a"));

            //ESEMPI DI ESPRESSIONI LAMBDA

            // (a, b) => a + b;
            // () => someMethod();

            //SINTASSI AD UN UNICO ARGOMENTO (DANNO LO STESSO RISULTATO)
            // (a) => someMethod(a);
            // a => someMethod(a);
        }
    }
}
