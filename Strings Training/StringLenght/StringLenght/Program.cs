using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine() + "********************" );
            Console.WriteLine(input.Substring(0,20));
        }
    }
}
