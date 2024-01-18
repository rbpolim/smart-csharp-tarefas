using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - Smart - Tarefa 08 | Somando Vetor");

            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Soma dos valores do vetor: {sum}");
            Console.Read();
        }
    }
}
