using System;
using System.Collections.Generic;
using S10V133_Etiqueta.Enteties;
using System.Globalization;

namespace S10V133_Etiqueta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                string situation = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (situation == "i")
                {
                    Console.Write("Customs fee: ");
                    double tax = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    price += tax;
                    list.Add(new ImportedProduct(name, price, tax));
                }
                else if (situation == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                }

                list.Add(new Product(name, price));
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
