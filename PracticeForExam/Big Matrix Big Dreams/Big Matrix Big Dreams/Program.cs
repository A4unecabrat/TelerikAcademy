using System;
using System.Linq;
using System.Numerics;

namespace Big_Matrix_Big_Dreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            //int N = int.Parse(Console.ReadLine());
            //int[] Moves = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            BigInteger[,] matrix = new BigInteger[R, C];
            BigInteger result = 0;
            for (int row = R - 1; row >= 0; row--)
            {
                int curentrow = row;
                for (int col = 0; col < R - row; col++)
                {
                    matrix[curentrow, col] = counter;
                    curentrow++;
                }
                counter = counter * 2;
            }
            for (int col = 1; col < C; col++)
            {
                int curentcol = col;
                for (int row = 0; row < R - col + 1; row++)
                {
                    matrix[row, curentcol] = counter;
                    curentcol++;
                }
                counter = counter * 2;
            }
            int posrow = R - 1;
            int poscol = 0;
            /*for (int i = 0; i < N; i++)
            {
                int destinationrow = Moves[i] / Math.Max(R, C);
                int destinationcol = Moves[i] % Math.Max(R, C);
                if (destinationcol > poscol)
                {
                    for (int j = poscol; j <= destinationcol; j++)
                    {
                        result += matrix[posrow, j];
                        matrix[posrow, j] = 0;
                    }
                }
                else
                {
                    for (int j = poscol; j >= destinationcol; j--)
                    {
                        result += matrix[posrow, j];
                        matrix[posrow, j] = 0;
                    }
                }
                poscol = destinationcol;
                if (destinationrow > posrow)
                {
                    for (int j = posrow; j <= destinationrow; j++)
                    {
                        result += matrix[j, poscol];
                        matrix[j, poscol] = 0;
                    }
                }
                else
                {
                    for (int j = posrow; j >= destinationrow; j--)
                    {
                        result += matrix[j, poscol];
                        matrix[j, poscol] = 0;
                    }
                }
                posrow = destinationrow;
            }*/
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(result);
        }
    }
}
