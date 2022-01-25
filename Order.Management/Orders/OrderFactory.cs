using System;
namespace Order.Management.Orders
{
    public static class OrderFactory
    {
        public static Order build(string customerName, string customerAddress, string dueDate)
        {
            // Do any validations on input here. Some examples
            // 1. customer address is valid
            // 2. due date is valid and not in the past

            Customer cust = new Customer(customerName, customerAddress);
            return new Order(cust, DateTime.Parse(dueDate), new ProductList());
        }
    }
}
