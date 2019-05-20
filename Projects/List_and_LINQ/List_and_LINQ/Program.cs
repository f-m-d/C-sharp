using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_LINQ
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //LINQ QUERY SQL SYNTAX
            var bmw = from car in myCars
                      where car.Make == "BMW"
                      select car;

            //OTTIENE LE MACCHINE IN ORDINE DI DATA
            var orderedCar = from car in myCars
                              orderby car.Year descending
                              select car;


            foreach (Car car in orderedCars)
            {
                Console.WriteLine("{0}, {1}, {2}", car.Model, car.Make, car.Year);
            }


            _ = Console.ReadKey();
            //LINQ METHOD SYNTAX

            var bmws = myCars.Where(c => c.Make == "BMW");
            var orderedCars = myCars.OrderByDescending(c => c.Year);

            foreach (Car car in orderedCars)
            {
                Console.WriteLine("{0}, {1}", car.Model, car.Make);
            }

            // ALTRA SINTASSI LAMBA DI FOREACH
            myCars.ForEach( p => Console.WriteLine(p.ToString()));

            _ = Console.ReadKey();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}

  
