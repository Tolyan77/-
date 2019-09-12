using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08._2019_product
{
    partial class Store
    {
        private Product[] product;
        public int size = 0;

        public Store()
        {
            for(int i = 0; i < 10; i++)
            {
                product[i] = new Product();
                size++;
            }
        }

        public int CountOfPred()
        {
            return product.Length;
        }

        public int CountOfProduct(ProductType type)
        {
            int count = 0;
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i].ProductInfo.type == type)
                    {
                        count++;
                    }
                }
                return count;
        }

        public decimal TotalPrice()
        {
            decimal summa = 0;
            for(int i = 0; i < product.Length; i++)
            {
                summa += product[i].ProductInfo.price;
            }
            return summa;
        }

        public decimal AveragePrice()
        {
            decimal sered = 0;
            for (int i = 0; i < product.Length; i++)
            {
                sered += product[i].ProductInfo.price;
            }
            sered = sered / product.Length;
            return sered;
        }
    }
}
