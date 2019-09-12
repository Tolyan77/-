using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08._2019_product
{
    enum ProductType : byte
    {
        Electronics, Sport, Medical, Food, Clothes
    }
    struct ProductInfo
    {
        public string name;
        public ProductType type;
        public decimal price;
        readonly public DateTime data;
        readonly public int key;

        public ProductInfo(string name, ProductType type, decimal price, int key)
        {
            this.key = key;
            this.name = name;
            this.type = type;
            this.price = price;
            this.data = DateTime.Now;
        }
    }
    class Product
    {
        private ProductInfo productInfo;
        private static int count;
        private Provider r;
        static  Product()
        {
           // productInfo = new ProductInfo();
            count++;
        }

        public ProductInfo ProductInfo
        {
            get { return productInfo; }
        }

        public Product()
        {
            SetData(out decimal price, out string name, out ProductType type);
            productInfo = new ProductInfo(name, type, price, count + 1000);
            r = new Provider();
            r.SetInfo("Oleksiu", "China");
            count++;
        }
        void SetData(out decimal price,out string name,out ProductType type)
        {
            //  price = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"\n\tName : ");
            name = Console.ReadLine();

            Console.WriteLine($"\n\tPrice : ");
            while (!decimal.TryParse(Console.ReadLine(),out price))
            {
                Console.WriteLine($"Incorect input!");
            }

            Console.WriteLine($"\n\tType : ");
            while (!Enum.TryParse(Console.ReadLine(), out type))
            {
                Console.WriteLine("Wrong type");
            }
        }
        public void Show()
        {
            Console.WriteLine($"\n\tName: {productInfo.name}\n" +
                $"Price: {productInfo.price}\n" +
                $"Type: {productInfo.type}\n");
            r.Show();
        }
    }
}



    

