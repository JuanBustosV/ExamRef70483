using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1._16ContinuationOptions
{
    class Program
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
            //throw new Exception(":(");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }

        public static void ExceptionTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Exception!");
        }

        static void Main(string[] args)
        {

            Console.Title = "16. Continuation Options";

            Task task = Task.Run(() => HelloTask());

            task.ContinueWith((prevTask) => WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask) => ExceptionTask(), TaskContinuationOptions.OnlyOnFaulted);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
