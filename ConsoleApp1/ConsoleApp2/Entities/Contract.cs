namespace ConsoleApp2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double total)
        {
            Number = number;
            Date = date;
            Total = total;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
