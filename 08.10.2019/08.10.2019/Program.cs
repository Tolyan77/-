using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._10._2019
{
    class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public DateTime DateProduct { set; get; }
        public string CountryProduct { set; get; }
        public int CategoryId { set; get; }
        public string Show()
        {
            return ("" +
                $"\n\tId :{Id}" +
                $"\n\tName :{Name}" +
                $"\n\tPrice :{Price}" +
                $"\n\tDate product :{DateProduct.ToShortDateString()}" +
                $"\n\tCountry product :{CountryProduct}" +
                $"\n\tCategory Id :{CategoryId}");
        }
    }

    class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Category> CategoryProduct = new List<Category>();
            CategoryProduct.Add(new Category() { Id = 1, Name = "Electronic", Description = "----" });
            CategoryProduct.Add(new Category() { Id = 2, Name = "Health", Description = "----" });
            CategoryProduct.Add(new Category() { Id = 3, Name = "Books", Description = "----" });
            CategoryProduct.Add(new Category() { Id = 4, Name = "Home", Description = "----" });
            CategoryProduct.Add(new Category() { Id = 5, Name = "Sport", Description = "----" });

            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 9001, Name = "Ball", Price = 30, DateProduct = new DateTime(2015, 7, 20), CountryProduct = "China", CategoryId = 5 });
            products.Add(new Product() { Id = 9002, Name = "Valerian", Price = 50, DateProduct = new DateTime(2018, 10, 5), CountryProduct = "Russia", CategoryId = 2 });
            products.Add(new Product() { Id = 9003, Name = "Wall", Price = 500, DateProduct = new DateTime(2016, 3, 27), CountryProduct = "Netherlands", CategoryId = 4 });
            products.Add(new Product() { Id = 9004, Name = "iPhone 8", Price = 1000, DateProduct = new DateTime(2019, 3, 2), CountryProduct = "India", CategoryId = 1 });
            products.Add(new Product() { Id = 9005, Name = "Bookmark", Price = 10, DateProduct = new DateTime(2014, 8, 10), CountryProduct = "France", CategoryId = 3 });
            products.Add(new Product() { Id = 9006, Name = "Tap", Price = 155, DateProduct = new DateTime(2017, 5, 17), CountryProduct = "Germany", CategoryId = 4 });
            products.Add(new Product() { Id = 9007, Name = "Racket", Price = 200, DateProduct = new DateTime(2018, 11, 22), CountryProduct = "USA", CategoryId = 5 });
            products.Add(new Product() { Id = 9008, Name = "Water", Price = 30, DateProduct = new DateTime(2019, 7, 25), CountryProduct = "Brazil", CategoryId = 2 });
            products.Add(new Product() { Id = 9009, Name = "Cover", Price = 20, DateProduct = new DateTime(2018, 6, 2), CountryProduct = "Ukraine", CategoryId = 3 });
            products.Add(new Product() { Id = 9010, Name = "TV", Price = 900, DateProduct = new DateTime(2018, 1, 3), CountryProduct = "Ireland", CategoryId = 1 });

            decimal min = 30, max = 300;
            var f = from p in products
                    where (p.Price >= min && p.Price <= max)
                    select p.Name;
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");

            string testName = "TV";

            var g = from p in products
                    where (p.Name == testName)
                    select p.Name;
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");
            string textCountry = "Ukraine";
            var q = from p in products
                    where (p.CountryProduct == textCountry && (DateTime.Now.Year - p.DateProduct.Year) <= 2)
                    select p.Name;
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            var q1 = from p in products
                     where (p.CountryProduct == textCountry && ((DateTime.Now - p.DateProduct).TotalDays / 365.25) <= 2)
                     select new
                     {
                         p.Name,
                         p.CountryProduct
                     };
            foreach (var item in q1)
            {
                Console.WriteLine(item);              
            }
            Console.WriteLine("-------------------------------------");
            string qq = "a";
            var n = from p in products
                     where (p.Name.Contains(qq))
                     select p.Name;
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            var qwery = products.Where(i => i.Name.Contains("a"));
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            decimal minn = products[0].Price, maxx = products[0].Price;
            for (int i = 0; i < 10; i++)
            {
                if(minn> products[i].Price)
                {
                    minn = products[i].Price;
                }
                if (maxx < products[i].Price)
                {
                    maxx = products[i].Price;
                }
            }
            var we = from p in products
                     where p.Price == maxx || p.Price == minn
                     select p.Name;
            foreach (var item in we)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            var wq = from p in products
                     where p.CountryProduct == "USA"
                     select p;
            wq = products.Where(p => p.CountryProduct == "USA");
            Console.WriteLine(wq.Sum(p => p.Price) / wq.Count());
            Console.WriteLine("-------------------------------------");
            var ss = from p in products
                     join c in CategoryProduct on p.CategoryId equals c.Id
                     where (p.Name != "")
                     select new
                     {
                         id = p.Id,
                         Name = p.Name,
                         Price = p.Price,
                         Data = p.DateProduct,
                         Country = p.CountryProduct,
                         Cat = c.Name
                     };
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
