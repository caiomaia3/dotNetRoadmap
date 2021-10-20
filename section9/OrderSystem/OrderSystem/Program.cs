using System;
using OrderSystem.Entities;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, productName;
            DateTime birthDay;
            OrderStatus status;
            int nItens,quantity;
            double price;

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Email:");
            email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            Client client = new Client(name, email, birthDay);
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many items to this order?");
            nItens = int.Parse(Console.ReadLine());
            for (int i = 0; i < nItens; i++)
            {
                Console.WriteLine("Enter #{0} item data:",i+1);
                Console.Write("Product name:");
                productName = Console.ReadLine();
                Console.Write("Product price:");
                price = double.Parse(Console.ReadLine());
                Console.Write("Quantity:");
                quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }
            Console.WriteLine(order.ToString());
        }
    }
}
