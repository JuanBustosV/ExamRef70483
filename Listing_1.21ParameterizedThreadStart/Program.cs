using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._21ParameterizedThreadStart
{
    class Program
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            Console.Title = "21. Passing data into a thread";

            ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            Thread thread = new Thread(ps);
            thread.Start(99);
        }
    }
}
