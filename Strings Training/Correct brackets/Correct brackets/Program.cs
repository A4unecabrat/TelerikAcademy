using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ')' && counter == 0)
                {
                    counter = 1;
                    break;
                }
                else if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')' && counter > 0)
                {
                    counter--;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
