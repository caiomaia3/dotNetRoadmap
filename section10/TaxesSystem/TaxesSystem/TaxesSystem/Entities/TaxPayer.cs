
using System.Globalization;

namespace TaxesSystem.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
        public string PrintTaxesPaid()
        {
            return $"{Name}: $ {this.TaxesPaid().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
