using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1._14TaskWaitall
{
    class Program
    {
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished", i);
        }

        static void Main(string[] args)
        {
            Console.Title = "14. Task Waitall";

            Task[] Tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                int taskNum = i; // make a local copy of the loop counter so that
                                 // correct task number is passed into the lambda expression

                Tasks[i] = Task.Run(() => DoWork(/*i*/taskNum)); // pasando i directamente toda tarea tiene número 10
            }
            Task.WaitAll(Tasks);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
