using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stck = new Stack();
            Queue qq = new Queue();


            Console.WriteLine(" ---- STACK ----");

            stck.Push("Marco");
            stck.Push("2");
            stck.Push(new object());

            Console.WriteLine("Terzo elemento inserito: " + stck.Pop().ToString());
            Console.WriteLine("Secondo elemento inserito: " + stck.Pop().ToString());
            Console.WriteLine("Primo elemento inserito: " + stck.Pop().ToString());


            Console.WriteLine(" ---- QUEUE ----");

            qq.Enqueue("Marco");
            qq.Enqueue("2");
            qq.Enqueue(new object());

            Console.WriteLine("Primo elemento inserito: " + qq.Dequeue().ToString());
            Console.WriteLine("Secondo elemento inserito: " + qq.Dequeue().ToString());
            Console.WriteLine("Terzo elemento inserito: " + qq.Dequeue().ToString());

            _ = Console.ReadKey();
        }
    }
}
