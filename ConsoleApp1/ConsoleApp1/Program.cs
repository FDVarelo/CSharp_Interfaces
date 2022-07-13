//--------------------------------------------------------------------------------------//
// Uma locadora brasileira de carros cobra um valor por hora para locações de até       //
// 12 horas.Porém, se a duração da locação ultrapassar 12 horas, a locação será         //
// cobrada com base em um valor diário. Além do valor da locação, é acrescido no        //
// preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%       //
// para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um               //
// programa que lê os dados da locação (modelo do carro, instante inicial e final da    //
// locação), bem como o valor por hora e o valor diário de locação. O programa          //
// deve então gerar a nota de pagamento (contendo valor da locação, valor do            //
// imposto e valor total do pagamento) e informar os dados na tela.                     //                                                                            //
//--------------------------------------------------------------------------------------//

using System;
using System.Globalization;
using ConsoleApp1.Services;
using ConsoleApp1.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtenção dos dados do usuário.
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (DD/MM/YYYY hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (DD/MM/YYYY hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            // Tratamento de erro.
            TimeSpan condition = finish.Subtract(start); 
            while(condition.Hours < 0.0) // Se o horario final for menor que o horario inicial (o que é impossível de acontecer).
            {
                Console.WriteLine("Date of Return early than the date of Pickup, try again.");

                Console.Write("Pickup (DD/MM/YYYY hh:mm): ");
                start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (DD/MM/YYYY hh:mm): ");
                finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                condition = finish.Subtract(start); // Testa novamente o horario final - horario inicial, caso de negativo ele entra novamente no while.
            }

            // Continuação dos dados do aluguel.
            Console.Write("Enter price per hour: "); // Preço por hora, no caso: Inicio = 10:00, Fim = 10:20 → Conta como 1 hora se passou, mesmo passando apenas 20 minutos.
            double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: "); // Passou de 24 horas;
            double perDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Cria o carro, com inicio e fim do aluguel, e o nome do carro;
            RentalCar car = new RentalCar(start, finish, new Vehicle(carModel));

            // Verifica o aluguel, passando o preço da hora, do dia, e a taxa a ser paga;
            RentalService rental = new RentalService(perHour, perDay, new BrTax());

            // Calcula o aluguel "Invoice" do veículo "car", levando em conta o preço "PerHour" e "PerDay", junto com a taxa "BrTax" do "RentalService",
            // e levando em consideração o inicio "Start" e fim "Finish" o veículo "car".
            rental.Invoice(car);

            Console.WriteLine("Invoice:");
            Console.WriteLine(car.Invoice); // Retorna o override o veículo "car" com o "Invoice"/aluguel.
        }
    }
}