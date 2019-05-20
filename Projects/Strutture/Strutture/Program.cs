using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutture
{
    //Le strutture possono contenere metodi, campi, priopieta' ed eventi

        public struct ComplexNumber
    {
        public float Real { get; set; }
        public float Complex { get; set; }


        public ComplexNumber(float Real, float Complex) : this()
        {
            this.Real = Real;
            this.Complex = Complex;
        }

        public static ComplexNumber Sum(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real, x.Complex + y.Complex);
        }


        public float getRealPart()
        {
            return Real;
        }

        public float getComplexPart()
        {
            return Complex;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //Creo due numeri complessi
            ComplexNumber cn1 = new ComplexNumber(5.0f , 5.0f);

            ComplexNumber cn2 = ComplexNumber.Sum(cn1, cn1);

            Console.WriteLine("Parte reale: "+ cn2.getRealPart());
            Console.WriteLine("Parte complessa: " + cn2.getComplexPart());

            _ = Console.ReadKey();
        }
    }
}
