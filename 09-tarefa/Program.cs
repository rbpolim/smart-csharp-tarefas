using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 09 | Imprimindo CSV");

            try
            {
                string csvFile = "csvFuncionarios.csv";

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string parsePath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\"));
                string combinePath = Path.Combine(parsePath, csvFile);

                string[] rows = File.ReadAllLines(combinePath);

                foreach (string row in rows)
                {
                    string[] values = row.Split(';');

                    if (values.Length == 3)
                    {
                        if (int.TryParse(values[0], out int wage))
                        {
                            string name = values[1];
                            string role = values[2];

                            Console.WriteLine($"Salário: {wage} - Funcionário: {name} - Cargo: {role}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: O arquivo 'csvFuncionarios.csv' não foi encontrado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
