﻿//--------------------------------------------------------------------------------------------------//
// Uma empresa deseja automatizar o processamento de seus contratos. O processamento de             //
// um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no        //
// número de meses desejado.                                                                        //
// A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.         //
// Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa             //
// por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica         //
// juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.                            //
// Fazer um programa para ler os dados de um contrato (número do contrato, data do contrato,        //
// e valor total do contrato). Em seguida, o programa deve ler o número de meses para               //
// parcelamento do contrato, e daí gerar os registros de parcelas a serem pagas (data e valor),     //
// sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois       //
// meses após o contrato e assim por diante. Mostrar os dados das parcelas na tela.                 //
//--------------------------------------------------------------------------------------------------//

using System;
using System.Globalization;
using ConsoleApp2.Entities;
using ConsoleApp2.Services;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value); // Cria o contrato

            ContractService contractService = new ContractService(new Paypal()); // Define o meio de pagamento;
            contractService.Contract(contract, installments); // No metodo de pagamento ele passa o contrato (Valor total a ser pago) e a quantidade de tempo a ser pago.

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
            
        }
    }
}