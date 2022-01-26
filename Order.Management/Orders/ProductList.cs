using System;
using System.Collections.Generic;
using System.Collections;
using Order.Management.Pricing;
using System.Linq;
namespace Order.Management.Orders
{
    public class ProductList
    {
        IEnumerable<Product> products = new List<Product>();

        public ProductList()
        {
        }

        public IEnumerable<Square> Squares()
        {
            return products.OfType<Square>();
        }

        public IEnumerable<Square> RedSquares()
        { 
            return Squares().Where(square => square.Color == "red");
        }

        public IEnumerable<Circle> Circles()
        {
            return products.OfType<Circle>();
        }

        public IEnumerable<Triangle> Triangles()
        {
            return products.OfType<Triangle>();
        }

        public decimal CostSquares()
        {
            return Squares().Sum(square => square.Price);
        }

        public IEnumerable<Product> Reds()
        {
            return products.Where(p => p.Color == "red");
        }

    }
}
