using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgramma
{
    class Program {

        public delegate void StringLogWriter(DateTime timestamp, string message);


        public class Logger
        {
            private StringLogWriter _writer;

            public Logger(StringLogWriter writer)
            {
                this._writer = writer;
            }


            public void Log(string message)
            {
                if(this._writer != null)
                {
                    this._writer(DateTime.Now, message);
                }
            }

        }


        public class FileLogWriter
        {
            public string FileName { get; set; }

            public FileLogWriter(string FileName)
            {
                this.FileName = FileName;
            }

            public void Write(DateTime timestamp, string message)
            {
                //SCRITTURA DEL MESSAGGIO SU FILE
            }

        }

        private static void ConsoleWriter(DateTime timestamp, string message)
        {
            Console.WriteLine("{0} - {1}", timestamp, message);
        }

        public static bool FindStringWithAnA(string s)
        {
            return s.Contains("a");
        }

        static void Main(string[] args)
        {
            //PREDICATE: PASSO UN PUTNATORE AD UNA FUNZIONE COME PARAMETRO

            string a = "Hello World!";
            string b = "Have a nice evening!";
            string c = "This text has an a";

            var aa= Program.FindStringWithAnA(a);
            var bb= Program.FindStringWithAnA(b);
            var cc= Program.FindStringWithAnA(c);

            Console.WriteLine("Se le stringhe a,b,c hanno una 'a': " + aa + bb + cc);

            List<string> ls = new List<string>();

            ls.Add(a);
            ls.Add(b);
            ls.Add(c);

            var foundString = ls.Find(FindStringWithAnA);

            Console.WriteLine(foundString);



            _ = Console.ReadKey();


            //DELEGATE: PUNTATORI A FUNZIONI FORTEMENTE TIPIZZATI
            //PASSO UNA FUNZIONE LA QUALE STAMPA A TERMINALE
            //E' UNA FUNZIONE VALIDA PERCHE' HA GLI STESSI ARGOMENTI VOLUTI DA LOGGER:
            //UNO STRINGLOGWRITER(DATA, STRING) MA UNA FUNZIONE WRITECONSOLE(DATA, STRING)
            var myLogger = new Logger(ConsoleWriter);

            myLogger.Log("Questo e' un messaggio di esempio.");

            _ = Console.ReadKey();

            //METODO A CUI SI AVRA' IL DELEGATE
            var writer = new FileLogWriter(@"C:\SOMETEXTFILE");

            //METODO DI DELEGATE, UTILIZZA IL METODO PRECEDENTE
            var writerDelegate = new StringLogWriter(writer.Write);
    
            // STAMPA IL METODO UTILIZZATO (WRITE DI WRITER)
            Console.WriteLine(writerDelegate.Method);

            // PUO' CONTINUARE A VEDERE GLI ARGOMENTI PASSATI ALL'OGGETTO DELLA FUNZIONE DELEGATA
            Console.WriteLine(((FileLogWriter) writerDelegate.Target).FileName);

            _ = Console.ReadKey();




            //UTILIZZO DEL MULTICAST DELEGATE
            //UTILIZZO: INVOCATION LIST, OVVERO PUNTARE A PIU' METODI CONTEMPORANEAMENTE
            //PER POI ESEGUIRLI IN SEQUENZA

            //OGGETTO, IL QUALE DELEGHERA' COL METODO WRITE 
            var writer1 = new FileLogWriter(@"C:\PATH\PRIMO\DELEGATE");

            //PRIMO DELEGATE
            var fileDelegate1 = new StringLogWriter(writer1.Write);

            //SECONDO DELEGATE
            var fileDelegate2 = new StringLogWriter(Program.ConsoleWriter);

            StringLogWriter combinedDelegate = (StringLogWriter)Delegate.Combine(fileDelegate1, fileDelegate2);

            var myLoggerDelegate = new Logger(combinedDelegate);

            myLoggerDelegate.Log("Messaggio di esempio");

            _ = Console.ReadKey();
        }
    }
}
