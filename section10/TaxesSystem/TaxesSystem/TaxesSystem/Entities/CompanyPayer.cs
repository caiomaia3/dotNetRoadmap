
namespace TaxesSystem.Entities
{
    class CompanyPayer : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public CompanyPayer(string name, double anualIncome, int employeeNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeeNumber;
        }

        public override double TaxesPaid()
        {
            const int EMPLOYEE_LIMIT = 10;
            double rate;

            if (EmployeesNumber < EMPLOYEE_LIMIT)
            {
                rate = 16;
            }
            else
            {
                rate = 14;
            }

            return (rate / 100) * AnualIncome;
        }
    }
}
