using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Listing_1._24SharedFlagVariable
{
    class Program
    {
        static bool tickRunning; // flag variable

        static void Main(string[] args)
        {
            Console.Title = "24. Aborting Threads with shared flag variable";

            tickRunning = true;

            Thread tickTread = new Thread(() =>
            {
                while (tickRunning)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            tickTread.Start();

            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickRunning = false;//tickTread.Abort();
            // Prueba pregunta examen 20483
            int a = 1;
            int b = 2;
            Console.WriteLine(a == --b && a == b++); // True
            Console.WriteLine("a: {0}, b: {1}", a, b);
            Console.WriteLine(a == --b || a == b++); // True, no se ejecuta la parte derecha, la izquierda ya es verdadera y es OR
            Console.WriteLine("a: {0}, b: {1}", a, b);
            Console.WriteLine(a == --b && b == a++); // False, no se ejecuta la parte derecha, la izquierda ya es falsa y es AND
            Console.WriteLine("a: {0}, b: {1}", a, b);

            string name = "Juan Bustos";
            int coins = 20;
            Console.WriteLine(String.Format("Player {0}, collected {1} coins", name, coins.ToString("###0")));
            // Console.WriteLine(String.Format("Player {1}, collected {2:D3} coins", name, coins)); Ni de coña

            int[] intArray = { 1, 2, 3, 4, 5 };

            for (int i =1; i < intArray.Length; i++)
            {
                intArray[i] += intArray[i - 1];
            }

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

            List<string> myData = new List<string>();
            myData.Add("string1");
            myData.Add("string2");
            myData.Add("string3");

            //for (int i = 0; i <= myData.Count; i++)
            //    myData.RemoveAt(i); ni de coña
            while (myData.Count != 0)
                myData.RemoveAt(0);

            Console.WriteLine("Quedan {0} elementos en myData", myData.Count);

            foreach (string s in myData)
                Console.WriteLine("valor: {0}", s);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
