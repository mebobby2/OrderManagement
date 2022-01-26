using System;
using Order.Management.Orders;
namespace Order.Management.Reports
{
    abstract class Report
    {
        public Order Order { get; set; }
      

        public abstract void GenerateReport();

      
    }
}
