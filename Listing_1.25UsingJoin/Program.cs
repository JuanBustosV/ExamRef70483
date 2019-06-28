using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._25UsingJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "25. Using Join";

            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread starting");
                Thread.Sleep(3000);
                Console.WriteLine("Thread done");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
