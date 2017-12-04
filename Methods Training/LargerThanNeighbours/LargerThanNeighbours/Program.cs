using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int size = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            for (int i = 0; i < size; i++)
            {
                if (LargerThanNeighbours(numbers, i))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static bool LargerThanNeighbours(int[] array, int position)
        {
            if (position < array.Length - 1 && position > 0)
            {
                return (array[position] > array[position - 1] && array[position] > array[position + 1]);
            }
            else
                return false;
        }
    }
}
