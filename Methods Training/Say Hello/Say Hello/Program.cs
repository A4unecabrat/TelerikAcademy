using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(SayHi(name));

        }
        static string SayHi(string name)
        {
            return string.Format("Hello, {0}!", name);
        }
    }
}
