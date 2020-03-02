using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        public static object Resource { get; set; }
        static void Main(string[] args)
        {
            Resource = 10;
            Thread.CurrentThread.Name = "MAIN";

            Thread th = new Thread(
                new ThreadStart(RunThreadUno));

            Thread th2 = new Thread(
                new ThreadStart(RunThreadDos));

            th.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.BelowNormal;

            th.Start();
            th2.Start();

            th.Join();

            Console.WriteLine($"name = {Thread.CurrentThread.Name}");
            Console.WriteLine($"recurso = {Resource}");
            Console.WriteLine($"Fin hilo principal");
        }


        public static void RunThreadUno()
        {
            Thread.CurrentThread.Name = "HILO UNO";
            var name = Thread.CurrentThread.Name;
            for (int i = 90; i <= 100; i++)
            {
                lock (Resource)
                {
                    Resource = Convert.ToInt32(Resource) + i;
                }
                //Thread.Sleep(500);
                Console.WriteLine($"nombre = {name}, value = {Resource}");

            }
            Console.WriteLine($"Fin subproceso {name}");
        }

        public static void RunThreadDos()
        {
            Thread.CurrentThread.Name = "HILO DOS";
            var name = Thread.CurrentThread.Name;
            for (int i = 0; i <= 20; i++)
            {
                i *= 2;

                lock (Resource)
                {
                    Resource = i * Convert.ToInt32(Resource);
                }
                //Thread.Sleep(500);
                Console.WriteLine($"nombre = {name}, value = {Resource}");

            }
            Console.WriteLine($"Fin subproceso {name}");
        }
    }
}
