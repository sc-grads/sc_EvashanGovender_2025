using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //Custom constructor to initialize customer details
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
           // Console.WriteLine("Customer created: " + Name);
        }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer() 
        { 
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No Contact Number";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
