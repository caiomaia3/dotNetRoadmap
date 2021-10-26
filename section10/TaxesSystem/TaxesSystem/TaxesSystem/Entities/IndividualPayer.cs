
namespace TaxesSystem.Entities
{
    class IndividualPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            const double INCOME_LIMIT = 20000, HEALTH_EXPEND_RATE=50;
            double rate;
            if (INCOME_LIMIT>AnualIncome)
            {
                rate = 15;
            }
            else
            {
                rate = 25;
            }
            return (rate / 100) * AnualIncome - (HEALTH_EXPEND_RATE / 100) * HealthExpenditures;
        }
    }
}
