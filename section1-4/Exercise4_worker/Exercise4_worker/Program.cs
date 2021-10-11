using System;

namespace Exercise4_worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker funcionario;
            double percentual=0;
            funcionario = new Worker();

            Console.WriteLine("Digite o nome ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do funcionário:"+funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário:");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));


            
        }
    }
}
