using System;
using System.Collections.Generic;
namespace Order.Management.Pricing
{
    public class Catalog
    {
        Dictionary<Product, decimal> pricesByProduct = new Dictionary<Product, decimal>();

        public Catalog()
        {
            Product redSquare = new Square(1, 1, "red");
            pricesByProduct.Add(redSquare, redSquare.Price);

            Product blueSquare = new Square(1, 0, "blue");
            pricesByProduct.Add(blueSquare, blueSquare.Price);

            Product yellowSquare = new Square(1, 0, "yello");
            pricesByProduct.Add(yellowSquare, yellowSquare.Price);
        }


    }
}
