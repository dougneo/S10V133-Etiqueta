using System;
using System.Globalization;

namespace S10V133_Etiqueta.Enteties
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag(string cui)
        {
            
        }
    }
}
