using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeObject
{

    public class DisposableObject : IDisposable
    {

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // SI LIBERANO RISORSE GESTITE
            }

            // SI LIBERANO QUELLE NON GESTITE
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableObject()
        {
            this.Dispose(false);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            var myObj = new DisposableObject();

            try
            {
                //METODO CHE GENERA L'ECCEZZIONE
            }

            finally
            {
                myObj.Dispose(true);
            }


            // SINTASSI DIVERSA, STESSO EFFETTO
            // OGGETTO DEVE IMPLEMENTARE L'INTERFACCIA IDISPOSABLE
            using (var myObject = new DisposableObject())
            {
                //METODO CHE GENERA L'ECCEZIONE
                myObject.ToString();
            }
        }
    }
}
