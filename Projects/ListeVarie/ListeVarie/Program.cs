using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeVarie
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTA: Lista definita di Oggetti, simile ad ArrayList
            List<String> stringlist = new List<string>();

            stringlist.Add("Ciao");

            //NON NECESSITO DI CASTING
            Console.WriteLine("" + stringlist[0].ToUpper());


            //LinkedList
            LinkedList<LinkedListNode<string>> ll = new LinkedList<LinkedListNode<string>>();

            LinkedListNode<string> lln1 = new LinkedListNode<string>("Ciao");
            LinkedListNode<string> lln2 = new LinkedListNode<string>("Come");
            LinkedListNode<string> lln3 = new LinkedListNode<string>("Stai?");

            ll.AddLast(lln2);
            ll.AddLast(lln3);
            ll.AddFirst(lln1);

            foreach(LinkedListNode<string> node in ll)
            {
                Console.WriteLine("Valore del nodo: " + node.Value + "\n");
            }

            _ = Console.ReadKey();

            

        }
    }
}
