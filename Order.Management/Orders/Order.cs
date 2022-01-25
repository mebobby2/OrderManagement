using System;
namespace Order.Management.Orders
{
    public class Order
    {
        public string OrderNumber { get; }
        public DateTime DueDate { get; }
        public Customer Customer { get; }

        public Order(Customer customer, DateTime dueDate, ProductList products)
        {
            this.OrderNumber = Guid.NewGuid().ToString();
            DueDate = dueDate;
            Customer = customer;
        }
    }
}
