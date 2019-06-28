using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1._10ExceptionsPLINQ
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static bool CheckCity(string name)
        {
            if (name == "")
                throw new ArgumentException("Current value of City: '" + name + "'");
            return name == "Seattle";
        }

        static void Main(string[] args)
        {

            Console.Title = "Exceptions in PLINQ queries";

            Person[] people = new Person[]
            {
                // Para pruebas quita la X y deja ciudades con cadena vacía
                new Person { Name = "Juan", City = "Motril"},
                new Person { Name = "Alan", City = "Hull"},
                new Person { Name = "Beryl", City = "Seattle"},
                new Person { Name = "Charles", City = "London"},
                new Person { Name = "David", City = "Seattle"},
                new Person { Name = "Eddy", City = "Paris"},
                new Person { Name = "Filipe", City = ""},
                new Person { Name = "Fred", City = "Berlin"},
                new Person { Name = "Gordon", City = "Hull"},
                new Person { Name = "Henry", City = "Seattle"},
                new Person { Name = "Ozzy", City = ""},
                new Person { Name = "Isaac", City = "Seattle"},
                new Person { Name = "James", City = "London"},
                new Person { Name = "Borja", City = ""}
            };


            try
            {
                var result = from person in people.AsParallel()
                             where CheckCity(person.City)
                             select person;

                result.ForAll(person => Console.WriteLine(person.Name));
            }
            // PLINQ nunca hace catch de excepciones individuales... 
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Data + " " + e.InnerException);
            //}
            catch (AggregateException e) // siempre usar AggregateException en PLINQ
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.InnerExceptions.Count + " exceptions.");
                Console.ResetColor();

                foreach (var iexp in e.InnerExceptions)
                    if (iexp is ArgumentException) // Podemos consultar el tipo de Excepction
                        Console.WriteLine("\tArgumentException: " + iexp.Message);
                    else Console.WriteLine("\tException: " + iexp.Message);
            }

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
