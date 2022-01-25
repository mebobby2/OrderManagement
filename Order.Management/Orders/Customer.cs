using System;
namespace Order.Management.Orders
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }


    }
}
