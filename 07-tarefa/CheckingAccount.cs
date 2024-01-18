using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_tarefa
{
    internal class CheckingAccount
    {
        public int CountId { get; set; }
        public string NameAccount { get; set; }
        public double Balance { get; set; }

        public void ProcessWithdrawal(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Saldo insuficiente. Saque não permitido.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Saque de R$ {amount} realizado com sucesso. Novo saldo: R$ {Balance}");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Saldo atual: R$ {Balance}");
        }
    }
}
