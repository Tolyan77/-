using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //int A = 220;
            //Console.WriteLine($"Hello, world {A}");
            //decimal c = 1;
            //decimal v = 3;
            //Console.WriteLine($"c / v = {c /= v}");
            //Console.WriteLine($"====================");
            //Console.WriteLine($"c * v = {c * v}");
            DateTime date = DateTime.Now;
            Console.WriteLine($"Now : {date}");

            Random rnd = new Random();
            int a = rnd.Next(10, 130);
            Console.WriteLine(a); 
        }
    }
}
