using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<upcase>(.*?)<\/upcase>";
            MatchCollection result = Regex.Matches(input, pattern);
            foreach (Match item in result)
            {
                input = input.Replace(item.Value, item.Groups[1].ToString().ToUpper());
            }
            Console.WriteLine(input);
        }
    }
}
