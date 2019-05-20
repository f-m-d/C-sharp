using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiConEventArgs
{

    //DATO DELLA PORTA, TRAMITE EVENT ARG
    public class PortDataReceivedEventArgs : EventArgs
    {
        public string Data { get; set; }

    }

    //PORT RECEIVER, PER RICEVERE I DATA
    public class PortReceiver
    {
        public delegate void PortDataReceivedEventHandler(object obj, EventArgs e);
        public event PortDataReceivedEventHandler PortDataReceived;


        protected virtual void OnPortDataReceived(string data)
        {
            if (this.PortDataReceived != null)
            {
                var e = new PortDataReceivedEventArgs();
                e.Data = data;
                this.PortDataReceived(this, e);
            }
        }


        public string Data {get;set;}


        public void ReceiveData()
        {
            this.Data = "Data received";
            this.OnPortDataReceived(Data);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
