using System;
namespace Order.Management.Pricing
{
    public class Circle : Product
    {
        private decimal _Price;
        private decimal _Surcharge;
        private string _Color;

        public Circle(decimal price, decimal surcharge, string color)
        {
            _Price = price;
            _Surcharge = surcharge;
            _Color = color;
        }

        public decimal Price 
        {
            get => _Price;
            set => _Price = value;
        }

        public decimal Surcharge
        {
            get => _Surcharge;
            set => _Surcharge = value;
        }

        public string Color
        {
            get => _Color;
            set => _Color = value;
        }

    }
}
