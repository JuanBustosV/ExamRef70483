using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._27ThreadContext
{
    class Program
    {
        static void DisplayThread(Thread t)
        {
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Culture: {0}", t.CurrentCulture);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("Context: {0}", t.ExecutionContext);
            Console.WriteLine("IsBackground?: {0}", t.IsBackground);
            Console.WriteLine("IsPool?: {0}", t.IsThreadPoolThread);
        }

        static void Main(string[] args)
        {
            Console.Title = "27. Thread Context";

            Thread.CurrentThread.Name = "Main method";
            DisplayThread(Thread.CurrentThread);

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();
        }
    }
}
