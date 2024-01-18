using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tarefa
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smart - Tarefa 02");
            Console.WriteLine("Entre com o símbolo de operação:");
            Console.WriteLine("( + ) - Adição");
            Console.WriteLine("( - ) - Subtração");
            Console.WriteLine("( * ) - Multiplicação");
            Console.WriteLine("( / ) - Divisão");

            string operation = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            if (!double.TryParse(Console.ReadLine(), out double firstValue))
            {
                Console.WriteLine("Entrada inválida para o primeiro valor.");
                Console.ReadLine();
                return;
            }

            Console.Write("Digite o segundo valor: ");
            if (!double.TryParse(Console.ReadLine(), out double secondValue))
            {
                Console.WriteLine("Entrada inválida para o segundo valor.");
                Console.ReadLine();
                return;
            }

            double result = Calculate(operation, firstValue, secondValue);

            Console.WriteLine($"Resultado: {result}");

            Console.Read();
        }

        static double Calculate(string operation, double firstValue, double secondValue)
        {
            switch (operation)
            {
                case "+":
                    return firstValue + secondValue;
                case "-":
                    return firstValue - secondValue;
                case "*":
                    return firstValue * secondValue;
                case "/":
                    if (secondValue != 0)
                    {
                        return firstValue / secondValue;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return double.NaN;
                    }
                default:
                    Console.WriteLine("Erro: Operação inválida.");
                    return double.NaN;
            }
        }
    }
}
