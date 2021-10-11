using System;
using System.Globalization;

namespace OOP_exercise2
{
    class Person
    {
        public string name;
        public double wage;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personA, personB;
            personA = new Person();
            personB = new Person();

            string text1 = "Dados do {0} funcionário:";
            double sumWages = 0;
            double meanWage = 0;

            Console.WriteLine(text1,"primeiro");
            Console.Write("Nome:");
            personA.name = Console.ReadLine();
            Console.Write("Salário:");
            personA.wage = double.Parse(Console.ReadLine());


            Console.WriteLine(text1, "segundo");
            Console.Write("Nome:");
            personB.name = Console.ReadLine();
            Console.Write("Salário:");
            personB.wage = double.Parse(Console.ReadLine());

            sumWages = personA.wage + personB.wage;
            meanWage = sumWages / 2;

            Console.WriteLine("Salário médio:"+meanWage.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine(' ');
            //Console.WriteLine("Idade:");
            //personA.wage = double.Parse(Console.ReadLine());
        }
    }
}
