using System;
using System.Collections.Generic;
using section14.Entities;

namespace section14.Services
{
    class ContractService
    {
        IPaymentService _paymentService;
       public ContractService(IPaymentService service)
       {
           _paymentService = service;
       }
        internal Contract NewContract(int number, DateTime date, double totalValue) => new Contract(number,date,totalValue);
        
        internal void ProccessContract(Contract cont, int month)
        {
            double amount = cont.totalValue/month;
            DateTime dueDate = cont.date;
            List<Installment> installments = new List<Installment>();
            for (int i = 0; i < month; i++)
            {
                double interest = _paymentService.MonthInterest(amount,i+1);
                double tax =  _paymentService.Tax(amount+interest);
                dueDate = dueDate.AddMonths(1);
                installments.Add(new Installment(dueDate,amount+interest+tax));
            }
            cont.installments = installments;
        }
    }
    
}