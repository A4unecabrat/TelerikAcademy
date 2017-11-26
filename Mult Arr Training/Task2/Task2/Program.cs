using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixsize = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = matrixsize[0];
            int m = matrixsize[1];
            int[,] matrix = new int[n, m];
            int maxsum = int.MinValue;
            for (int row = 0; row < n; row++)
            {
                int[] mininput = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = mininput[col];
                }
            }
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    maxsum = Math.Max(sum, maxsum);
                }
            }


            /*for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (col < m - 1)
                    {
                        Console.Write(string.Format("{0} ", matrix[row, col]));
                    }
                    else
                    {
                        Console.Write(string.Format("{0}", matrix[row, col]));
                    }
                }
                Console.WriteLine();
            }*/
            Console.WriteLine(maxsum);

        }
        static int Sum(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }
    }
}
