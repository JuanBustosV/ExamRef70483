using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._26ThreadLocal
{
    class Program
    {
        public static ThreadLocal<Random> RandonGenerator = new ThreadLocal<Random>(() => {
            return new Random(2);
        });


        static void Main(string[] args)
        {
            Console.Title = "26. Thread Local";

            Thread t1 = new Thread(() => {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("t1: {0}", RandonGenerator.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            Thread t2 = new Thread(() => {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("t2: {0}", RandonGenerator.Value.Next(10));
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
