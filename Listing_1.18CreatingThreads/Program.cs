using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._18CreatingThreads
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
            Console.Title = "18. Creating Threads";

            Thread thread = new Thread(ThreadHello);
            thread.Start();
        }
    }
}
