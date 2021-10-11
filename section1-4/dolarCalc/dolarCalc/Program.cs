using System;
using System.Globalization;

namespace dolarCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar:");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares vai comprar?");
            double valorDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor a ser pago em Reais = {0}",
                              DollarCalc.Converter2Reais(cotacao,valorDolar).ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
