using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventiLearning
{

    public class Counter
    {
        // (1): CREO L'EVENTO
        public event EventHandler ThreshHoldReached;
        // (2) DELEGATO: INTERMIEDARIO (PUNTATORE)
        // TRA ORIGINE EVENTO E  CODICE PER GESTIRE L'EVENTO
        public delegate void ThresholdReachedEventHandler(object sender, EventArgs e);

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = this.ThreshHoldReached;
            handler?.Invoke(this, e);
        }

    }

    // (3) NEL CASO L'EVENTO NECESSITASSE DI ARGOMENTI
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }


    class Program
    {

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The Treshold ");
        }

        static void Main(string[] args)
        {

            

            // RISPONDERE AGLI EVENTI
            var c = new Counter();

            //c_ThresholdReached e' il metodo che gestira' l'evento
            c.ThreshHoldReached += c_ThresholdReached;

        }
    }
}
