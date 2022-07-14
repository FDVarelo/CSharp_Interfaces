using System.Globalization;
namespace ConsoleApp6.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csv)
        {
            string[] vet = csv.Split(','); // Dividir a cada virgula.
            Name = vet[0];
            //Salary = vet[1]; // Impossível, pois vet é string
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee!");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
