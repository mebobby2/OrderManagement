using System;
namespace Order.Management.Pricing
{
    public interface Product
    {
        decimal Price { get; set; }
        decimal Surcharge { get; set; }
        string Color { get; set; }
    }
}
