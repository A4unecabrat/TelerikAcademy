using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixsize = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = matrixsize[0];
            int m = matrixsize[1];
            int[,] matrix = new int[n, m];
            int maxseq = 0;
            for (int row = 0; row < n; row++)
            {
                int[] mininput = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = mininput[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    bool rows = true;
                    bool cols = true;
                    bool upperdiag = true;
                    bool lowerdiag = true;
                    int rowscounter = 0;
                    int colscounter = 0;
                    int upperdiagconter = 0;
                    int lowerdiagcounter = 0;
                    for (int i = 0; i < Math.Max(n,m); i++)
                    {
                        if(!rows && !cols && !upperdiag && !lowerdiag)
                        {
                            break;
                        }
                        if(col + i >= m ||  matrix[row,col + i] != matrix[row, col])
                        {
                            rows = false;
                        }
                        if(row + i >= n || matrix[row + i, col] != matrix[row, col])
                        {
                            cols = false;
                        }
                        if(row + i >= n || col + i >= m || matrix[row + i,col + i] != matrix[row,col])
                        {
                            lowerdiag = false;
                        }
                        if(row - i <= 0 || col + i >= m || matrix[row - i,col + i] != matrix[row,col])
                        {
                            upperdiag = false;
                        }
                        if(rows)
                        {
                            rowscounter++;
                        }
                        if (cols)
                        {
                            colscounter++;
                        }
                        if(upperdiag)
                        {
                            upperdiagconter++;
                        }
                        if(lowerdiag)
                        {
                            lowerdiagcounter++;
                        }
                    }
                    maxseq = Math.Max(maxseq, Math.Max(colscounter, Math.Max(upperdiagconter, Math.Max(lowerdiagcounter, rowscounter))));
                }
            }
            Console.WriteLine(maxseq);
        }
    }
}
