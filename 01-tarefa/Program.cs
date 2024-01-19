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
            Console.WriteLine("C# - Smart - Tarefa 01 | Par ou Ímpar\n");
            Console.WriteLine("Digite um número: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
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

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
