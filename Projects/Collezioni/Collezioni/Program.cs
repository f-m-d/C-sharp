using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY DI PRIMITIVI
            int[] integerArray = { 1, 4, 8, 3, 6, 0, 1, 7, 3, 2, 8, 8, 8, 1 };

            Array.Sort(integerArray);
            Console.WriteLine("" + integerArray.Length);

            Array.Resize(ref integerArray, 5);

            Console.WriteLine("" + integerArray.Length);



            //ARRAYLIST = USATO PER ELEMENTI OBJECT GENERICI, NECESSITA DI CASTIN
            var arraylista = new ArrayList();

            arraylista.Add(5);
            arraylista.Add(7.0);
            arraylista.Add("Ciao");

            Console.WriteLine("Oggetto ArrayList:" + arraylista[0].ToString());
            

            foreach(object element in arraylista)
            {
                Console.WriteLine("Oggetto ArrayList:" + element.ToString());
            }

            Console.ReadKey();


            //Alcuni metodi degli array:
            var arraylistProva = new ArrayList();

            //Add: Aggiunge un elemento
            arraylistProva.Add("Ciao");

            //Add Range: Aggiunge alla fine una lista di elementi
            arraylistProva.AddRange(new ArrayList{ 1, 2, "Ciao" });

            foreach (object element in arraylistProva) { Console.WriteLine("Metodo ADD_RANGE: " + element.ToString()); }

            //Clone: Clona l'arraylist
            arraylistProva.Clone();

            //Contains(item) : verifica se contiene un oggetto
            if(arraylistProva.Contains("Ciao")){ Console.WriteLine("Metodo CONTAINS: Testato"); }

            // Proprieta' Count: Numero di elementi al suo interno
            Console.WriteLine("Metodo COUNT: " + arraylistProva.Count);

            //IndexOf: Indice dell'oggetto passato
            Console.WriteLine("Metodo INDEX_OF: " + arraylistProva.IndexOf("Ciao"));

            //Insert(indice, oggetto da inserire)
            arraylistProva.Insert(0, "Ciao");

            //Remove: rimouve l'elemento inserito
            arraylistProva.Remove("Come");






            //LIST: LISTA DI DETERMINATO OGGETTI
            List<String> list = new List<string>();

            list.Add("Marco");
            list.Add("Giulia");
            list.Add("Luca");

            list.Insert(0, "Primo");

            foreach(string s in list)
            {
                Console.Write("String: " + s + "\n");
            }

            _ = Console.ReadKey();
        }
    }
}
