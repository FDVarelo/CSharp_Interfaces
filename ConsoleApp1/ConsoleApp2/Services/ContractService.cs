using System;
using ConsoleApp2.Entities;

namespace ConsoleApp2.Services
{
    class ContractService
    {
        private OnlinePay onlinePay;
        public ContractService(OnlinePay onlinePay)
        {
            this.onlinePay = onlinePay;
        }

        public void Contract(Contract contract, int months) // Contrato tera como parametros o contrato em si, e os meses que ele ira pagar aquele contrato.
        {
            double Quota = contract.Total / months; // Quota é o que ele ita pagar no mês, tendo como base, o total a ser pago, dividido pelo total de meses.
            for(int i = 1; i <= months; i++) // Roda a quantidade de meses.
            {
                DateTime date = contract.Date.AddMonths(i); // Adiciona 1 mês (próxima parcela a ser paga). 
                double updateQuota = Quota + onlinePay.Interest(Quota, i); // Novo_Quota é o proprio Quota + a taxa mensal.
                double totalQuota = updateQuota + onlinePay.Fee(updateQuota); // Quota final é o Novo_Quota + a taxa de pagamento.
                contract.AddInstallment(new Installment(date, totalQuota)); // Adiciona o novo installment no contrato, com a data e o total a ser pago naquela data.
            }
        }
    }
}
