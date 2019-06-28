using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._22ThreadLambdaParameters
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
            Console.Title = "22. Thread lambda parameters";

            Thread thread = new Thread((data) => 
            {
                WorkOnData(data);
            });

            thread.Start(99);
        }
    }
}
