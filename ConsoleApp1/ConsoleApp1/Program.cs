using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            for(int i = 0; i < 5; i++)
            {
                h += i;
                Console.WriteLine($"Number {h - 1}+1 = {h} ");
            }
            Console.WriteLine($"End");
            Console.ReadKey();
        }
    }
}
