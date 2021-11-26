using System;
using System.Globalization;
using section14.Entities;
using section14.Services;
namespace section14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8028;
            DateTime date = DateTime.Parse("2018-06-25");
            double totalValue = 600;
            int month =3;
            
            ContractService contService = new ContractService(new PayPalService());
            Contract cont = contService.NewContract(number, date, totalValue);
            contService.ProccessContract(cont,month);
            Console.Write(cont.ToString());
        }
    }

}
