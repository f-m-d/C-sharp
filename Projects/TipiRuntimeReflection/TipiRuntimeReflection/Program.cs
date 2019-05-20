using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TipiRuntimeReflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            foreach (Type type in currentAssembly.GetTypes())
            {
                
                Console.WriteLine(type);
            }

            _ = Console.ReadKey();

            Assembly MSCoreLib = Assembly.GetAssembly(typeof(int));

            Console.WriteLine(MSCoreLib.FullName);
            Console.WriteLine(MSCoreLib.Location);

            _ = Console.ReadKey();
        }
    }
}
