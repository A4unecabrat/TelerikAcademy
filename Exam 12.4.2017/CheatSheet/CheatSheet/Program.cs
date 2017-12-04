using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number[0] == '-')
            {
               number = number.Remove(0, 1);
            }
            int[] input = number.Select(digit => int.Parse(digit.ToString())).ToArray();
            Array.Reverse(input);
            BigInteger result = 0;
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                if((i + 1) % 2 != 0)
                {
                    result += input[i] * (i + 1) * (i + 1);
                }
                else
                {
                    result += input[i] * input[i] * (i + 1);
                }
            }
            Console.WriteLine(result);
            if (result % 10 == 0)
            {
                Console.WriteLine("Big Vik wins again!");
            }
            else
            {
                int lastdigit = (int)result % 10;
                int letter = (int)result % 26;
                for (int i = 0; i < lastdigit; i++)
                {
                    if(letter == letters.Length)
                    {
                        letter = 0;
                    }
                    Console.Write(letters[letter]);
                    letter++;
                }
            }
        }
    }
}   
