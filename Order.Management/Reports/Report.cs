using System;
using Order.Management.Orders
namespace Order.Management.Reports
{
    abstract class Report
    {
        public Order Order { get; set; }
      

        public abstract void GenerateReport();

        public string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + Address + " Due Date: " + DueDate + " Order #: " + OrderNumber;
        }
    }
}
