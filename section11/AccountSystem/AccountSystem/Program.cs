using System;
using System.Globalization;
using AccountSystem.Entities;
namespace AccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter accout data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Account acc = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine("");

            Console.Write("Enter amount for withdraw: ");
            try
            {
                acc.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine(acc);
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
