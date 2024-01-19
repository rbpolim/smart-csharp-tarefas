using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 06 | Aluno mais alto\n");

            int totalStudents = 5;
            string tallestStudent = "";
            double tallestHeight = 0;

            for (int i = 1; i <= totalStudents; i++)
            {
                Console.Write($"Digite o nome do estudante {i}: ");
                string name = Console.ReadLine();

                Console.Write($"Digite a altura do estudante {i} (em metros, utilize vírgula para decimais): ");
                if (!double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double height))
                {
                    Console.WriteLine("Erro: Altura inválida! Tente novamente.");
                    i--;
                    continue;
                }

                if (height > tallestHeight)
                {
                    tallestHeight = height;
                    tallestStudent = name;
                }
            }

            if (!string.IsNullOrEmpty(tallestStudent))
            {
                Console.WriteLine($"O estudante mais alto é: {tallestStudent} com uma altura de {tallestHeight} metros.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sem registro de estudantes.");
            }
        }
    }
}
