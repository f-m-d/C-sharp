using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventi
{

    // SENZA EVENTI
    // CLASSE NON CORRETTA: COSTRINGE A SCRIVERE PIU' VERSIONI DEL METODO SUBSCRIBE
    public class PortReceiver
    {
        public delegate void DataReceivedCallback();
        private DataReceivedCallback callback;

        public string Data { get; set; }


        public void Subscribe(DataReceivedCallback callback)
        {
            this.callback = callback;
        }

        public void ReceiveData()
        {
            this.Data = "Data received!";

            if(this.callback != null)
            {
                this.callback();
            }
        }

    }



    public class SomeClass
    {
        private PortReceiver receiver;

        public SomeClass(PortReceiver receiver)
        {
            this.receiver = receiver;
        }

        private void DataReceived()
        {
            Console.WriteLine(this.receiver.Data);
        }
    }



    /// <summary>
    /// CON GLI EVENTI
    /// </summary>
    /// 


        // CON EVENTI

        public class PortReceiverEvent
    {
        public delegate void PortDataReceivedEventHandler(PortReceiverEvent receiver);
        //Best pratice per Microsoft:
        public delegate void myEventHandler(object obj, EventArgs e);

        public event PortDataReceivedEventHandler PortDataReceived;

        public string Data { get; set; }


        protected virtual void OnPortDataReceived()
        {
            this.PortDataReceived(this);
        }


        public void ReceiveData()
        {
            this.Data = "Data received with event!";
            if(PortDataReceived != null)
            {
                myEventHandler(this, EventArgs.Empty);
            }
        }
    }


    public class SomeClassEvent
    {

        public SomeClassEvent(PortReceiverEvent receiver)
        {
            receiver.PortDataReceived += DataReceived;
        }


        private void DataReceived(PortReceiverEvent receiver)
        {
            Console.WriteLine(receiver.Data);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
