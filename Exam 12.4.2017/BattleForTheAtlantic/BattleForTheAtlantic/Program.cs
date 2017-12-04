using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BattleForTheAtlantic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] battlefield = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[,] player1 = new int[battlefield[0], battlefield[1]];
            int[,] player2 = new int[battlefield[0], battlefield[1]];
            string input = string.Empty;
            for (int row = 0; row < 2*battlefield[0]; row++)
            {
                int[] colinput = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                if (row < battlefield[0])
                {
                    for (int col = 0; col < battlefield[1]; col++)
                    {
                        player1[row, col] = colinput[col];
                    }
                }
                else
                {
                    for (int col = 0; col < battlefield[1]; col++)
                    {
                        player2[row - battlefield[0], col] = colinput[col];
                    }
                }
            }
            while(input != "END")
             {
                int row = Convert.ToInt32(Regex.Match(input, @"\d+ ").Groups[1]);
                int col = Convert.ToInt32(Regex.Match(input, @"((\d *)[^\d]) *$)").Groups[2]);
                input = Console.ReadLine();
                if (Regex.Match(input, "P1").Success)
                {
                    if(player2[row, col] == 1)
                    {
                        Console.WriteLine("Boom");
                    }
                    else
                    {
                        Console.WriteLine("Missed");
                    }
                }
                else
                {
                    if (player1[row, col] == 1)
                    {
                        Console.WriteLine("Boom");
                        player1[row, col] = null;
                    }
                    else
                    {
                        Console.WriteLine("Missed");
                    }
                }
             }
        }
    }
}
