namespace ConsoleApp2.Services
{
    interface OnlinePay
    {
        double Fee(double amount);
        double Interest(double amount, int months);
    }
}
