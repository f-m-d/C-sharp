using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Umano
    {

        public Umano()
        {
            this.Name = "DEFAULT_NAME";
            this.Surname = "DEFAULT_SURNAME";
            this.Age = 1234567;

        }

        public Umano(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

    }



        class Program
    {
        static void Main(string[] args)
        {

            Umano u = new Umano();
            Console.WriteLine("Definizione di umano: " + u.ToString());
            Console.WriteLine(value: "Nome: " + u.Name);
            Console.WriteLine(value: "Cognome: " + u.Surname);
            Console.WriteLine(value: "Age: " + u.Age);

            u = new Umano("Francesco", "D'Auria", 22);

            Console.WriteLine("Definizione di umano: " + u.ToString());
            Console.WriteLine(value: "Nome: " + u.Name);
            Console.WriteLine(value: "Cognome: " + u.Surname);
            Console.WriteLine(value: "Age: " + u.Age);

            u.Name = "SetFrancesco";
            u.Surname = "SetDauria";
            u.Age = 10000;

            Console.WriteLine("Definizione di umano: " + u.ToString());
            Console.WriteLine(value: "Nome: " + u.Name);
            Console.WriteLine(value: "Cognome: " + u.Surname);
            Console.WriteLine(value: "Age: " + u.Age);


            _ = Console.ReadKey();

        }
    }
}
