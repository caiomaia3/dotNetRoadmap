using System;
using TaxesSystem.Entities;
using System.Collections.Generic;

namespace TaxesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int nTaxPayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < nTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                double heathExpend;
                int nEmployees;
                switch (c)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        heathExpend = double.Parse(Console.ReadLine());
                        TaxPayer taxPayer = new IndividualPayer(name, anualIncome, heathExpend);
                        payers.Add(taxPayer);
                        break;
                    case 'c':
                        Console.Write("Number of employees:");
                        nEmployees = int.Parse(Console.ReadLine());
                        payers.Add(new CompanyPayer(name, anualIncome, nEmployees));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer p in payers)
            {
                Console.WriteLine(p.PrintTaxesPaid());
            }
        }
    }
}
