using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nMaxQuartos = 10;
            Console.WriteLine("How many rooms will be rented?");
            int nQuartos = int.Parse(Console.ReadLine());

            if (nQuartos > nMaxQuartos)
            {
                nQuartos = nMaxQuartos;
            }
            if (nQuartos<=0)
            {
                nQuartos = 0;
            }

            Quartos[] quartos = new Quartos[nMaxQuartos];

            for (int i = 0; i < nQuartos; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Rent #{0}", i+1);
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int room = int.Parse(Console.ReadLine());
                quartos[room] = new Quartos(name, email, room);
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < nMaxQuartos; i++)
            {
                if (quartos[i]!=null)
                {
                    Console.WriteLine(quartos[i]);
                }
                //


            }
            //Pegar n entradas
            //Relacionar quartos
        }
    }
}
