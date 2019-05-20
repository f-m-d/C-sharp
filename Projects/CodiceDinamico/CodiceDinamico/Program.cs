using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodiceDinamico
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ha {1} anni", Name, Age);
        }

    }

    class Program
    {
        

        static void Main(string[] args)
        {
            //Riferimento per tipo
            Type personType = Type.GetType("CodiceDinamico.Person, CodiceDinamico");

            //Tramite il costruttore di default (senza parametri) ne costruiamo un istanza
            ConstructorInfo constructor = personType.GetConstructor(Type.EmptyTypes);
            object person = constructor.Invoke(null);

            //Tramite PropertyInfo valorizziamo Age e Name
            PropertyInfo nameProperty = personType.GetProperty("Name");
            PropertyInfo ageProperty = personType.GetProperty("Age");

            nameProperty.SetValue(person,"Marco de Sanctis", null);
            ageProperty.SetValue(person, 33, null);

            //Visualizziamo il toString()
            Console.WriteLine(person.ToString());

            _ = Console.ReadKey();

            //KEYWORD DYNAMIC
            Type personTypeDinamic = Type.GetType("CodiceDinamico.Person, CodiceDinamico");
            dynamic personDynamic = Activator.CreateInstance(personTypeDinamic);

            personDynamic.Name = "Mario De Certa";
            personDynamic.Age = 40;

            Console.WriteLine(personDynamic.ToString());

            _ = Console.ReadKey();

            int[] numbers = new int[10];
            List<int> numberslist = new List<int>();


            switch (numbers[3])
            {
                case 1: // do something
                    break;

                default: break;
            }

            int numero = 12345689;

            Console.WriteLine(String.Format("{0:C}", numero));


            _ = Console.ReadKey();

        }
    }
}
