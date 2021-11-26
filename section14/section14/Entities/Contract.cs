using System;
using System.Collections.Generic;
using System.Globalization;
using section14.Services;

namespace section14.Entities
{
    internal class Contract
    {
        public int number { get; private set; }
        public DateTime date { get; private set; }
        public double totalValue { get; private set; }

        public List<Installment> installments; 
        public Contract(int number, DateTime date, double total)
        {
            this.number = number;
            this.date = date;
            this.totalValue = total;
        }
        
        public override string ToString()
        {
            string msg = "Installments\n";
            foreach (Installment i in installments)
            {
                msg = msg + i.ToString() + "\n";
            }
            return msg;

        }
   }
}