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
            string[] input = Console.ReadLine().Split('.','?','!');
            StringBuilder result = new StringBuilder();
            foreach (var sentence in input)
            {
                if(new Regex(Regex.Escape(word)).Matches(sentence).Count > 0)
                {
                    result.Append(sentence + '.');
                }
            }
            Console.WriteLine(result);
        
        }
    }
}
