using ConsoleApp1.Entities; // RentalCar

namespace ConsoleApp1.Services
{
    class RentalService
    {
        public double PerHour { get; private set; }
        public double PerDay { get; private set; }

        private TaxService _taxService;

        public RentalService(double perHour, double perDay, TaxService taxService)
        {
            PerHour = perHour;
            PerDay = perDay;
            _taxService = taxService;
        }

        public void Invoice(RentalCar rentalCar)
        {
            TimeSpan duration = rentalCar.Finish.Subtract(rentalCar.Start); // Pegar duração do tempo decorido do fim menos o começo do aluguel do carro.

            double Payment = 0.0;

            if(duration.TotalHours <= 12.0) // Taxa por hora.
            {
                Payment = PerHour * Math.Ceiling(duration.TotalHours);
            }
            else // Taxa por dia.
            {
                Payment = PerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(Payment); // Taxa com relação ao Payment, que pode ser por dia ou por hora.

            rentalCar.Invoice = new Invoice(Payment, tax);
        }
    }
}
