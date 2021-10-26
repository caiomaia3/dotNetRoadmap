using System.Globalization;
using AccountSystem.Entities.Exceptions;

namespace AccountSystem.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set;}

        Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            bool overWithdrawLimit = value > WithdrawLimit;
            bool insuficientBalance = value > Balance;

            if (overWithdrawLimit)
            {
                string msg = "The withdraw value is over the limit.";
                throw new DomainException(msg);
            }
            
            if (insuficientBalance)
            {
                string msg = "Insuficient funds to do this withdraw.";
                throw new DomainException(msg);
            }

            Balance -= value;
        }

        public override string ToString()
        {
            return $"New balance: {Balance.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
