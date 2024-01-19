using System;
using System.IO;

namespace _04_tarefa
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("C# - Smart - Tarefa 04 | Calculadora IMC");

            string path = "C:\\Users\\rbpol\\Desktop\\imc.txt";

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Novo Cadastro");
                Console.WriteLine("2. Consultar Cadastros");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção (1/2/3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register(path);
                        break;
                    case "2":
                        GetAllRegisters(path);
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

        static void Register(string path)
        {
            Console.WriteLine("\nNovo Cadastro");

            Console.Write("Digite o nome: ");
            string username = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Idade inválida. Digite novamente.");
            }

            Console.Write("Peso (kg): ");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
            {
                Console.WriteLine("Peso inválido. Digite novamente.");
            }

            Console.Write("Altura (m): ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Altura inválida. Digite novamente.");
            }

            string imc = CalculateIMC(weight, height);

            RecordRegister(path, username, age, weight, height, imc);

            Console.WriteLine($"Resultado IMC: {imc} \nCadastro realizado.");
        }

        static void GetAllRegisters(string path)
        {
            Console.WriteLine("\nConsultar Cadastros");

            if (!File.Exists(path))
            {
                Console.WriteLine("Nenhum cadastro encontrado.");
                return;
            }

            string[] rows = File.ReadAllLines(path);

            if (rows.Length == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado.");
                return;
            }

            Console.WriteLine("Registros:");

            foreach (string row in rows)
            {
                Console.WriteLine(row);
            }
        }

        static string CalculateIMC(double weight, double height)
        {
            double imc = weight / (height * height);

            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }

            if (imc >= 18.5 && imc < 25)
            {
                return "Peso normal";
            }

            return "Sobrepeso";
        }

        static void RecordRegister(string path, string username, int age, double weight, double height, string imc)
        {
            string separator = "\n--------------";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"\nNome: {username}; \nIdade: {age}; \nPeso: {weight} kg; \nAltura: {height} m; \nIMC: {imc} \nCriado em: {DateTime.Now}; {separator}");
            }
        }
    }
}
