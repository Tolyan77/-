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
            string[] teams = { "Congratulations!", "Today is your day.", "You’re off to Great Places!", "You’re off and away!", "You have brains in your head.", "You have feet in your shoes." };

            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
        }
    }
}
