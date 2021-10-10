using System;

namespace OOP_exercise1
{

    class Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personA, personB;

            personA = new Person();
            personB = new Person();

            Console.Write("Digite o nome da pessoa:");
            personA.name = Console.ReadLine();

            Console.Write("Digite a idade da pessoa:");
            personA.age = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome da pessoa:");
            personB.name = Console.ReadLine();

            Console.Write("Digite a idade da pessoa:");
            personB.age = int.Parse(Console.ReadLine());

            bool isAGreater = personA.age > personB.age;
            Console.Write("A pessoa mais velha é: ");
            if (isAGreater)
            {
                Console.Write(personA.name);
            }
            else
            {
                Console.Write(personB.name);
            }
        }

    }
}
