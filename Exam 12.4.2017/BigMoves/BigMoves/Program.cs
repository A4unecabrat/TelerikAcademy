using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BigMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            int[] field = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int forwardsum = 0;
            int backwardssum = 0;
            string input = string.Empty;
            while (input != "exit")
            {
                input = Console.ReadLine();
                if (Regex.Match(input, "forward").Success)
                {
                    int steps = Convert.ToInt32(Regex.Match(input, @"\d+").Value);
                    int jump = Convert.ToInt32(Regex.Match(input, @"(\d*)[^\d]*$").Value);
                    for (int i = 0; i < steps; i++)
                    {
                        position += jump;
                        while (position > field.Length - 1)
                        {
                            position = position - field.Length;
                        }
                        forwardsum += field[position];
                    }
                }
                else if (Regex.Match(input, "backwards").Success)
                {
                    int steps = Convert.ToInt32(Regex.Match(input, @"\d+").Value);
                    int jump = Convert.ToInt32(Regex.Match(input, @"(\d*)[^\d]*$").Value);
                    for (int i = 0; i < steps; i++)
                    {
                        position -= jump;
                        while (position < 0)
                        {
                            position = position + field.Length;
                        }
                        backwardssum += field[position];
                    }
                }
            }
            Console.WriteLine("Forward: {0}", forwardsum);
            Console.WriteLine("Backwards: {0}", backwardssum);
        }
    }
}