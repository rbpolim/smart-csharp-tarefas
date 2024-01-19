using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Console.WriteLine("\nPressione qualquer tecla para sair...");
//Console.ReadKey();

namespace _10_tarefa
{
    internal class Program
    {
        static void Main()
        {
            // Criar uma matriz 3x3
            int[,] matriz = new int[3, 3];

            // Preencher a matriz com os valores fornecidos pelo usuário
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Informe o valor para a posição [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Exibir a matriz original
            Console.WriteLine("\nMatriz Original:");
            ImprimirMatriz(matriz);

            // Chamar a função TransposeHorizontal para transpor a matriz horizontalmente
            int[,] transposta = TransporMatrizHorizontal(matriz);

            // Exibir a matriz transposta horizontalmente
            Console.WriteLine("\nMatriz Transposta Horizontalmente:");
            ImprimirMatriz(transposta);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static int[,] TransporMatrizHorizontal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposed = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[i, j] = matrix[i, j];
                }
            }

            return transposed;
        }

        static void ImprimirMatriz(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
