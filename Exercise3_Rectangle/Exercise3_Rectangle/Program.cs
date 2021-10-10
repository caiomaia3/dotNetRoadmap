using System;
using System.Globalization;

namespace Exercise3_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle;

            rectangle = new Rectangle();

            Console.WriteLine("Entre com a altura e largura do retângulo:");
            rectangle.heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA:{0}",rectangle.Area());
            Console.WriteLine("PERÍMETRO:{0}",rectangle.Perimetro());
            Console.WriteLine("DIAGONAL:{0}",rectangle.Diagonal());
        }
    }
}
