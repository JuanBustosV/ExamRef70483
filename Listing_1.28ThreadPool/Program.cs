using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._28ThreadPool
{
    class Program
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);

            if ((int)state == 49) // fin ultimo trabajo
            {
                Console.WriteLine("\nPress a key to exit");                
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "28. Thread pool";

            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }

            Console.ReadKey();
        }
    }
}
