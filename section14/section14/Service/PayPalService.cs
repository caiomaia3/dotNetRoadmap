using System;
using section14.Services;

namespace section14
{
    internal class PayPalService : IPaymentService
    {
        public PayPalService()
        {
        }

        double IPaymentService.MonthInterest(double amount, int month)
        {
            double interestRate = 0.01;
            return amount*month*interestRate;
        }

        double IPaymentService.Tax(double amount)
        {
            const double taxRate = 0.02;
            return amount*taxRate;
        }
    }
}