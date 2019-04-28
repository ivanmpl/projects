using System;
using System.Collections.Generic;

namespace NewLanguageFeatures
{

    class Program
    {
        static void Main(string[] args)
        {
            var customers = CreateCustomers();

            var otherCustomer = new Customer(10)
            {
                Name = "Diego Ruiz",
                City = "Barcelona"
            };

            foreach (Customer customer in customers)
            {
                if (otherCustomer.Compare(customer))
                {
                    System.Console.WriteLine("The other customer is already on list");
                    return;
                }
            }

            System.Console.WriteLine("The other customer was not on the list");

            List<Customer> addedCustomers = new List<Customer>
            {
                new Customer(9) { Name="Paulo Accorti",City="Toronto"},
                new Customer(10) { Name="Diego Rivera",City="Madrid"}
            };

            var updatedCustomers = customers.Append(addedCustomers);

            /* 
            foreach (var customer in updatedCustomers)
            {
                System.Console.WriteLine(customer.CustomerID + "\t" + customer.Name + "\t" + customer.City);
            }*/

            foreach (var customer in updatedCustomers)
            {
                foreach (var c in FindCustomersByCity(updatedCustomers, "London"))
                    Console.WriteLine(c);
            }



            /*
            List<Point> Square = new List<Point>
            {
                new Point() {X=0,Y=5},
                new Point() {X=5,Y=5},
                new Point() {X=5,Y=0},
                new Point() {X=0,Y=0}
            };*/



        }

        public



        public static List<Customer> FindCustomersByCity(List<Customer> cust, string city)
        {
            return cust.FindAll(c => c.City == city);
        }

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
                new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
                new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                new Customer(4) { Name = "Ann Devon",        City = "London"    },
                new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
            };
        }
    }
}
