using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccezioniTrow
{
    


    class Program
    {
        public static void SomeMethod(List<int> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            //fai cose
        }


        static void Main(string[] args)
        {
        }
    }
}
