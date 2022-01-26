using System;
using Order.Management.Pricing;
using System.Collections.Generic;
using System.Linq;
namespace Order.Management.Orders
{
    public class Order
    {
        public string OrderNumber { get; }
        public DateTime DueDate { get; }
        public Customer Customer { get; }
        private ProductList products;

        public Order(Customer customer, DateTime dueDate, ProductList productList)
        {
            this.OrderNumber = Guid.NewGuid().ToString();
            DueDate = dueDate;
            Customer = customer;
            products = productList;
        }

        public decimal Surcharge()
        {
            return products.Reds().Sum(p => p.Price);
        }
    }
}
