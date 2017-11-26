using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            int occurrences = 0;
            int startingIndex = 0;

            while ((startingIndex = input.IndexOf(substring, startingIndex)) >= 0)
            {
                ++occurrences;
                startingIndex += substring.Length;
            }

            Console.WriteLine(occurrences);
        }
    }
}
