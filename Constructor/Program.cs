using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, Firstname = "Hakkı", Lastname = "Karakaş", City = "İzmir" };
            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.Firstname = "Ali";
            customer1.Lastname = "Veli";
            customer1.City = "İstanbul";
            //customer ve customer1 yazım şekilleri aynıdırlar.

            Customer customer2 = new Customer(3,"Veli","Ali","Erzurum");
            List<Customer> customers = new List<Customer>() { customer,customer1,customer2};
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id+" "+ item.Firstname + " " + item.Lastname + " " + item.City );
            }
            
        }
    }
}
