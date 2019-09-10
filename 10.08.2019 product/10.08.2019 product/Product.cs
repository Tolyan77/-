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
        readonly public  DateTime data;
        readonly public int key;

        public ProductInfo (string name, ProductType type, decimal price, int key)
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

        static Product()
        {
            count = 0;
        }
        public  Product()
        {
            productInfo = new ProductInfo();
            count++;
        }
        public Product(string name, ProductType type, decimal price,int key)
        {
            productInfo = new ProductInfo();
            count++;

        }
        void SetData(out decimal price,out string name,out ProductType type)
        {
            //  price = decimal.Parse(Console.ReadLine());
            while(!decimal.TryParse(Console.ReadLine(),out price))
            {
                Console.WriteLine($"Incorect input!");
            }
            name = Console.ReadLine();
            type = Console.ReadLine();
        }
    }
}



    

