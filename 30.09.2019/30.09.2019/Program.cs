using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09._2019
{
    class Program
    {
        class Square : IDisposable
        {
            public void Show(ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(@"      ### 
    ##   ##
  ##       ##   
##    ###    ## 
    ##   ##  
  ##       ##
##           ##
");
            }
            public void Dispose()
            {
                Console.ResetColor();
            }

            public void Show()
            {
                Console.WriteLine(@"      ### 
    ##   ##
  ##       ##   
##    ###    ## 
    ##   ##  
  ##       ##
##           ##
");
            }
        }
        static void Main(string[] args)
        {
            Square a = new Square();
            Console.WriteLine("Enter color: ");
            string colorUse = Console.ReadLine();

            try
            {
                a.Show((ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorUse));
            }
            finally
            {
                a.Dispose();
            }

            a.Show();
        }
    }
}
