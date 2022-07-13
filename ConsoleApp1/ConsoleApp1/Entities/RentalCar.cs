namespace ConsoleApp1.Entities
{
    class RentalCar
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; } // Pagamento/Fatura/Total

        public RentalCar(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; // Começa null, pois ainda não sabemos o valor.
        }
    }
}
