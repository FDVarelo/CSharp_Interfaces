namespace ConsoleApp2.Services
{
    class Paypal : OnlinePay
    {
        private const double FeePercent = 0.02;
        private const double InterestPerMonth = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * months * InterestPerMonth;
        }
        public double Fee(double amount)
        {
            return amount * FeePercent;
        }
    }
}
