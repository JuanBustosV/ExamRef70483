using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba01
{
    public static class CustomersExtensions
    {
        public static void Add(this Customers cs, Customer c) => cs.AddCustomer(c);
    }

    public class Customer
    {
        public string Name;
        public int Age;
    }

    public class Customers : IEnumerable<Customer>
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer c)
        {
            customers.Add(c);
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            return ((IEnumerable<Customer>) customers).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Customer>)customers).GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customers()
            {
                new Customer {Name = "Neil", Age = 45},
                new Customer {Name = "Jon", Age = 43},
                new Customer {Name = "Peter", Age = 98}
            };            

            foreach (var c in customers)
                Console.WriteLine("Nombre y edad: {0} {1}", c.Name, c.Age);
        }
    }
}
