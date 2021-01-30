using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int Id, string Firstname, string Lastname, string City)
        {
            this.Id = Id;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.City = City;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }

}
