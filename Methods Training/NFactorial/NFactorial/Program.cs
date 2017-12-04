using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NFactorial(number));
        }
        static int NFactorial(int number)
        {
            int result = 1;
            for ( int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;  
        }
    }
}
