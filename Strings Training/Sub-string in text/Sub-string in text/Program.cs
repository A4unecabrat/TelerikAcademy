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
            int count = new Regex(substring).Matches(input).Count;
            Console.WriteLine(count);
        }
    }
}