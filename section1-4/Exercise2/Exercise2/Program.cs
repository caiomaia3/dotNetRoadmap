using System;
using System.Globalization;

namespace Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo?");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int nRooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double product = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(nRooms);
            Console.WriteLine(product);

            Console.WriteLine("Entre com seu último nome, idade e altura (Na mesma linha separados por espaço):");
            string [] str2Parse = Console.ReadLine().Split(' ');

            name = str2Parse[0];
            int age = int.Parse(str2Parse[1]);
            float heigth = float.Parse(str2Parse[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(heigth);
        }
    }
}
