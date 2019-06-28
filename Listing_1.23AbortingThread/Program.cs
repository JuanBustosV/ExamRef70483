using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._23AbortingThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "23. Aborting Threads";

            Thread tickTread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            tickTread.Start();

            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickTread.Abort();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
