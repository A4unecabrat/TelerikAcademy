using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }
        static string ReverseNumber(string number)
        {
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}