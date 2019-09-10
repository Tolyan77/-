 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08._2019_product
{
    class Provider
    {
        private string name;
        private string country;
        private short rating;
        private bool isPayVAT;

        public void Show() {
            char r = '*';
            string rat = new string(r, rating);
            Console.WriteLine($"\n\tName : {name}\n" +
                $"\tCountry : {country}\n" +
                $"\tRating : {((rating == 0) ? "No rating" : rat)}\n" + 
                $"\tIs pay VAT :{ ((isPayVAT == true) ? " true " : " false ")}");

        }
        public void SetInfo(string name, string country)
        {
            this.name = name;
            this.country = country;
            Random rnd = new Random();
            rating = (short)rnd.Next(0, 6);
            isPayVAT = (rating > 2);
        }
    }
}
