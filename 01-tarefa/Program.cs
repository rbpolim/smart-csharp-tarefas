using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smart - Tarefa 01");
            Console.WriteLine("Digite um número: ");

            // Recebe a entrada do usuário
            string input = Console.ReadLine();

            // Converte a entrada para um número inteiro
            if (int.TryParse(input, out int number))
            {
                // Verifica se o número é par ou ímpar
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} é um número par.");
                }
                else
                {
                    Console.WriteLine($"{number} é um número ímpar.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

            Console.Read();
        }
    }
}
