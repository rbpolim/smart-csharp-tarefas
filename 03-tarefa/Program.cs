using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 03");
            Console.WriteLine("Calculadora de Reajuste Salarial");

            Console.Write("Digite o salário atual: ");
            if (!double.TryParse(Console.ReadLine(), out double currentWage))
            {
                Console.WriteLine("Erro: Entrada inválida para o salário.");
                Console.Read();
                return;
            }
            
            const double below = 300.00;
            const double above = 200.00;
            const double limit = 1700.00;
            
            double adjustment = currentWage < limit ? below : above;
            double newWage = currentWage + adjustment;

            Console.WriteLine($"O novo salário é: R$ {newWage}");

            Console.Read();
        }
    }
}
