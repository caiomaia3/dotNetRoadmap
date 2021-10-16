using System;

namespace GerenciamentoContaBacaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito;
            ContaBancaria conta;

            Console.Write("Entre o numéro da conta:");
            int idConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial?(s/n)");
            string selection = Console.ReadLine();

            bool depositar = (selection[0] == 's') || (selection[0] == 'S');
            if (depositar)
            {
                Console.WriteLine("Qual o valor a ser depositado: R$ ");
                deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(idConta, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(idConta, titular);
                Console.WriteLine(conta);
            }

            Console.Write("Entre o valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);

            Console.Write("Entre o valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);
        }
    }
}
