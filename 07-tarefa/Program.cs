using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 07 | Conta Corrente");
            CheckingAccount account = new CheckingAccount
            {
                CountId = 1,
                NameAccount = "Exemplo de Correntista",
                Balance = 1000.00
            };

            while (true)
            {
                Console.WriteLine("\nDigite a opção desejada:");
                Console.WriteLine("1 - Consultar saldo");
                Console.WriteLine("2 - Realizar saque");
                Console.WriteLine("3 - Sair");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        account.CheckBalance();
                        break;
                    case "2":
                        Console.Write("Digite o valor do saque: ");
                        if (double.TryParse(Console.ReadLine(), out double valorSaque))
                        {
                            account.ProcessWithdrawal(valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
