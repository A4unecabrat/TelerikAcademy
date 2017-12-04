using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount(array, number));
        }
        static int AppearanceCount(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
