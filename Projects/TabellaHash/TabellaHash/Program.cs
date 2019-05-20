using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelleHash
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //HASHTABLE(CHIAVE, VALORE)
            //PUO' ESSERE FORTEMENTE TIPIZZATA TIPO new HashTable<int, string>();
            Hashtable ht = new Hashtable();

            //Inserisce degli elementi
            ht.Add("chiave", "valore");
            ht.Add("IntValue", 10);
            ht.Add("SomeClass", new StringWriter());
            ht.Add(DateTime.Today, "Data di oggi");

            //Recupera un elemento tramite la chiave
            string stringa = (string) ht["chiave"];

            Console.WriteLine("Valore di 'chiave' : " + stringa);

            //Rimuove un elemento tramite la chiave
            ht.Remove("IntValue");

            //
            bool b = ht.ContainsValue("Data di oggi");

            Console.WriteLine("Metodo CONTAINS_VALUE: " + b);

            //Come scorrere l'HashTable

            //Per coppia chiave-valore
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(" Dictionary entry: " +  de.Key +"," + de.Value);
            }

            //Enumerazione di tutte le chiavi
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(" Dictionary key: " + key);
            }

            //Enumerazione di tutte le chiavi
            foreach (object value in ht.Values)
            {
                Console.WriteLine(" Dictionary key: " + value);
            }
            _ = Console.ReadKey();




            //HASHSET: INSIEME NON ORDINATO DI VALORI UNIVOCI

            HashSet<String> hs = new HashSet<string>();
            hs.Add("Ciao");
            hs.Add("Come");
            hs.Add("Stai?");

            string[] stringarray = { "Numero", "Lettera", "Colore" };
            hs.UnionWith(stringarray);

            foreach(string s in hs)
            {
                Console.WriteLine("Elemento dell'HashSet: " + s + "\n");
            }

            _ = Console.ReadKey();

        }
    }
}
