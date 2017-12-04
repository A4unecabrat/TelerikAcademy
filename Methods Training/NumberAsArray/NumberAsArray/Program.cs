using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] firstnumber = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] secondnumber = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine(NumberAsArray(firstnumber, secondnumber));
        }
        static string NumberAsArray(int[] firstnumber, int[] secondnumber)
        {
            int[] result = new int[Math.Max(firstnumber.Length, secondnumber.Length)];
            int naum = 0;
            for (int i = 0; i < Math.Min(firstnumber.Length, secondnumber.Length); i++)
            {
                result[i] = firstnumber[i] + secondnumber[i] + naum;
                if(result[i] > 9)
                {
                    naum = 1;
                    result[i] = result[i] - 10;
                }
                else
                {
                    naum = 0;
                }
            }
            return string.Join(" ", result);
        }

    }
}
