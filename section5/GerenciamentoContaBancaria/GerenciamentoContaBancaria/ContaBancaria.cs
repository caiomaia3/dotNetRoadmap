using System;
using System.Globalization;
namespace GerenciamentoContaBacaria
{
    class ContaBancaria
    {
        private const int SALDO_INICIAL_NULO = 0;
        private static double _tarifa = 5;
        private double _saldo;
        public int IdConta { private set; get; }
        public string NomeTitular { private set; get; }

        public ContaBancaria(int IdConta, string NomeTitular)
        {
            this.IdConta = IdConta;
            this.NomeTitular = NomeTitular;
            _saldo = SALDO_INICIAL_NULO;
        }
        public ContaBancaria(int IdConta, string NomeTitular, double Saldo) : this(IdConta, NomeTitular)
        {
            Deposito(Saldo);
        }
        public override string ToString()
        {
            return "Dados da conta:\nConta " + IdConta
                + ", Titular: " + NomeTitular + ", Saldo: $"
                + _saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
        public void Deposito(double valor)
        {
            _saldo += valor;
            Console.WriteLine(this);
        }
        public void Saque(double valor)
        {
            _saldo -= (valor + _tarifa);
            Console.WriteLine(this);
        }
    }
}
