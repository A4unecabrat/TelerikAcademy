using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] input = Console.ReadLine().Split('.');
            StringBuilder result = new StringBuilder();
            string pattern = @"(^|\W|[0-9_])" + Regex.Escape(word) + @"($|\W|[0-9_])";
            //MatchCollection matches = Regex.Matches(input, pattern);
            foreach (string item in input)
            {
                if(Regex.Match(item, pattern).Success)
                {
                    result.Append(item + '.');
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
