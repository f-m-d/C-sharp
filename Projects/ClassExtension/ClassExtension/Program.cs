using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExtension
{

    public class Animale
    {
        public virtual void Mangia()
        {
            Console.WriteLine("" + ToString() +": Mangia con la bocca.");
        }

        public virtual void Beve()
        {
            Console.WriteLine("" +ToString() + ": Beve con la bocca.");
        }
    }


    public class Umano : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("" + ToString() + ": Mangia con la bocca e le mani.");
        }

        public override void Beve()
        {
            //Richiama il metodo della superclasse
            base.Beve();
        }

   

    }



    //sealed: non puo' essere piu' estesa
    public sealed class Cane : Animale
    {

        public override void Mangia()
        {
            Console.WriteLine("" + ToString() + ": Mangia con la bocca e le fauci.");
        }

        public override void Beve()
        {
            //Richiama il metodo della superclasse
            Console.WriteLine("" + ToString() + ": Beve con la bocca e la lingua.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Animale a = new Animale();
            Umano u = new Umano();
            Cane c = new Cane();

            a.Mangia();
            a.Beve();

            u.Mangia();
            u.Beve();

            c.Mangia();
            c.Beve();

            _ = Console.ReadKey();

        }
    }
}
