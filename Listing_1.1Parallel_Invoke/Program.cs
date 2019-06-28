using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1._1Parallel_Invoke
{
    class Program
    {
        internal static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        internal static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        static void Main(string[] args)
        {
            Console.Title = "Parallel Invoke";

            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
