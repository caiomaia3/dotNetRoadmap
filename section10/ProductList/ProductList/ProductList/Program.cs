using System;
using ProductList.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            Console.Write("Enter the number of products:");
            int nProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < nProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product();

                switch (c)
                {
                    case 'c':
                        productList.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureTime = DateTime.Parse(Console.ReadLine());
                        productList.Add(new UsedProduct(name, price, manufactureTime));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        productList.Add(new ImportedProduct(name, price, customFee));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in productList)
            {
                Console.WriteLine(p.PriceTag());
            }

        }

    }
}
