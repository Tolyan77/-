using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQ_07._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "Gays", "Person", "element", "number", "Dimon", "Join" };
            string[] words2 = { "Planet", "system", "Piter", "Join", "Hospital", "number" };
            IEnumerable<string> result;

            var selectedResults = words1.Union(words2).Where(item => Char.IsUpper(item[0]));
         
            foreach (string s in selectedResults)
                Console.WriteLine(s);
        }
    }
}
