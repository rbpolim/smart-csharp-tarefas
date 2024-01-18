using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_tarefa
{
    internal class ContaCorrente
    {
        public int IdConta { get; set; }
        public string NomeCorrentista { get; set; }
        public double Saldo { get; set; }

        public void RealizarSaque(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente. Saque não permitido.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Novo saldo: R$ {Saldo}");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo}");
        }
    }
}
