using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] CharArray = input.ToCharArray();
            Array.Reverse(CharArray);
            Console.WriteLine(new string(CharArray));
        }
    }
}
