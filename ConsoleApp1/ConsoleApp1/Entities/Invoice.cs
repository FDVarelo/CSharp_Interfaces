using System.Globalization;

namespace ConsoleApp1.Entities
{
    class Invoice
    {
        public double Payment { get; set; }
        public double Tax { get; set; }

        public Invoice(double payment, double tax)
        {
            Payment = payment;
            Tax = tax;
        }

        public double TotalPay
        {
            get { return Payment + Tax; } // Valor total ((Tempo * ValorDoTempo) + ValorDaTaxa(PorDia ou PorHora))
        }

        public override string ToString()
        {
            return "Basic payment: " // Valor sem taxa.
                + Payment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: " // Valor da Taxa.
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: " // Valor final com taxa inclusa.
                + TotalPay.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
