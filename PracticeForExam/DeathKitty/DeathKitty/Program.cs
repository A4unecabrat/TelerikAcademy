using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathKitty
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] field = Console.ReadLine().ToCharArray();
            int[] path = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int position = 0;
            int food = 0;
            int souls = 0;
            int deadlocks = 0;
            int counter = 0;
            bool flag = true;

            if(field[position] == 'x')
            {
                flag = false;
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", counter);
            }
            else if(field[position] == '@')
            {
                souls++;
                field[position] = ' ';
            }
            else
            {
                food++;
                field[position] = ' ';
            }
            if (flag)
            {
                while (counter < path.Length)
                {
                    position += path[counter];
                    counter++;
                    while (position < 0)
                    {
                        position += field.Length;
                    }
                    while (position > field.Length - 1)
                    {
                        position -= field.Length;
                    }
                    if (field[position] == '@')
                    {
                        souls++;
                        field[position] = ' ';
                    }
                    else if (field[position] == '*')
                    {
                        food++;
                        field[position] = ' ';
                    }
                    else if (field[position] == 'x')
                    {
                        if (position % 2 == 0)
                        {
                            if (souls == 0)
                            {
                                flag = false;
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", counter);
                                break;
                            }
                            else
                            {
                                souls--;
                                field[position] = '@';
                                deadlocks++;
                            }
                        }
                        else
                        {
                            if (food == 0)
                            {
                                flag = false;
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", counter);
                                break;
                            }
                            else
                            {
                                food--;
                                field[position] = '*';
                                deadlocks++;
                            }
                        }
                    }
                }
                if(flag)
                {
                    Console.WriteLine(string.Format("Coder souls collected: {0}", souls));
                    Console.WriteLine(string.Format("Food collected: {0}", food));
                    Console.WriteLine(string.Format("Deadlocks: {0}", deadlocks));
                }
            }
        }
    }
}