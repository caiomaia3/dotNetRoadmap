namespace section14.Services
{
    internal interface IPaymentService
    {
        double MonthInterest(double amount, int month);
        double Tax(double amount);
    }
}