using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                char style = char.Parse(Console.ReadLine());
                int[,] matrix = new int[n, n];
                int counter = 1;
                //a
                if (style == 'a')
                {
                    for (int col = 0; col < n; col++)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                }
                //b
                else if (style == 'b')
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < n; row++)
                            {
                                matrix[row, col] = counter;
                                counter++;
                            }
                        }
                        else
                        {
                            for (int row = n - 1; row >= 0; row--)
                            {
                                matrix[row, col] = counter;
                                counter++;
                            }
                        }
                    }
                }
                //c
                else if (style == 'c')
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        int curentrow = row;
                        for (int col = 0; col < n - row; col++)
                        {
                            matrix[curentrow, col] = counter;
                            curentrow++;
                            counter++;
                        }
                    }
                    for (int col = 1; col < n; col++)
                    {
                        int curentcol = col;
                        for (int row = 0; row < n - col; row++)
                        {
                            matrix[row, curentcol] = counter;
                            curentcol++;
                            counter++;
                        }
                    }
                }
                //d
                else if (style == 'd')
                {
                    int minrow = 0;
                    int mincol = 0;
                    int maxrow = n - 1;
                    int maxcol = n - 1;
                    while (minrow <= maxrow || mincol <= maxcol)
                    {
                        for (int row = minrow; row <= maxrow; row++)
                        {
                            matrix[row, mincol] = counter;
                            counter++;
                        }
                        for (int col = mincol + 1; col <= maxcol; col++)
                        {
                            matrix[maxrow, col] = counter;
                            counter++;
                        }
                        for (int row = maxrow - 1; row >= minrow; row--)
                        {
                            matrix[row, maxcol] = counter;
                            counter++;
                        }
                        for (int col = maxcol - 1; col >= mincol + 1; col--)
                        {
                            matrix[minrow, col] = counter;
                            counter++;
                        }
                        mincol++;
                        minrow++;
                        maxcol--;
                        maxrow--;
                    }
                }
                else
                {
                    Console.WriteLine("Don't be that guy...");
                }
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col < n - 1)
                        {
                            Console.Write(string.Format("{0} ", matrix[row, col]));
                        }
                        else
                        {
                            Console.Write(string.Format("{0}", matrix[row, col]));
                        }
                    }

                    Console.WriteLine();
                }

            }
        }
    }
