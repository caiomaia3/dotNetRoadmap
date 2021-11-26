using System;
using System.Globalization;

namespace section14.Services
{
    internal class Installment
    {
        public DateTime dueDate { get; set; }
        public double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.amount = amount;
            this.dueDate = dueDate;
        }

        public override string ToString()
        {
            return dueDate.Date.ToString("dd-MM-yyyy") + " - " + amount.ToString("F2",CultureInfo.InstalledUICulture);                
        }
        
        
    }
}