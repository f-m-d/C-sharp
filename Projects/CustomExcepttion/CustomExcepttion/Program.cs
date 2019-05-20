using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcepttion
{
    // SI PUO' EREDITARE UNA EXCEPTION DA: SYSTEM_EXCEPTION E APPLICATION_EXCEPTION
    // APPLICATION E'USATA PER LE CUSTOM EXCEPTION

    [Serializable]
    public class InvalidCustomerException : ApplicationException
    {
        public object obj { get; set; }

        public InvalidCustomerException(object obj)
        {
            Console.WriteLine("Object " + obj.ToString() + "is not a valid object.");
        }


        //COSTRUTTORE CON MESSAGGIO
        public InvalidCustomerException(object obj, string message) : base(message)
        {
            this.obj = obj;
        }
            

        public InvalidCustomerException(object obj, string message, Exception innerException): base(message, innerException)
        {
            this.obj = obj;
        }


        public InvalidCustomerException(System.Runtime.Serialization.SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
