using System;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório.";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string msg = ", cujo o preço é ";

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}{1}{2:F2}",produto1, msg, preco1);
            Console.WriteLine("{0}{1}{2:F2}", produto2, msg, preco2);
            Console.WriteLine("");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero {genero}.");

            Console.WriteLine("Medida com oito casa decimais:{0:F8}.", medida);
            Console.WriteLine("Arredondado (três casas decimais):{0:F8}.", medida);
            Console.WriteLine("Separador decimal invariant culture:"+medida.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
