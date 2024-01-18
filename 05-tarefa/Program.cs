using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 05 | Contador de Frase");
            Console.Write("\nDigite uma palavra ou frase: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"Quantidade de vogais na palavra/frase: {vowelCount}");
            Console.Read();
        }

        static int CountVowels(string input)
        {
            int countVowel = 0;

            foreach (char letter in input.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    countVowel++;
                }
            }

            return countVowel;
        }
    }
}
