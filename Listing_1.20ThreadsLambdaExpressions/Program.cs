using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._20ThreadsLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20. Threads and lambda expressions";

            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Hello from the thread.");
                Thread.Sleep(1000);
            });

            thread.Start();
            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }
    }
}
