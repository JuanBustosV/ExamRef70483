using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1._4ManagingParallelFor
{
    class Program
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        static void Main(string[] args)
        {
            Console.Title = "Managing Parallel For";

            var items = Enumerable.Range(0, 500).ToArray(); // items de [0] a [499]
            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 200)
                    loopState.Break();//.Stop();

                WorkOnItem(items[i]);
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration); // Valor si se detiene con Break()

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
