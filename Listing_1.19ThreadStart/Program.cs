using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._19ThreadStart
{
    class Program
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            Console.Title = "19. Using ThreadStart";

            ThreadStart ts = new ThreadStart(ThreadHello); // Ya no es necesario, obsoleto

            Thread thread = new Thread(ts);
            thread.Start();

        }
    }
}
