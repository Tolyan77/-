using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08._2019_product
{
    partial class Store
    {
        public override string ToString()
        {
            string s = "";
            for(int i =0;i< product.Length; i++)
            {
                s += product[i].ProductInfo.name + product[i].ProductInfo.price + product[i].ProductInfo.type;
            }
            return s;
        }

        public void AddProduct()
        {
            product[size] = new Product();
            size++;
        }
        public void GetProd(int key)
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].ProductInfo.key == key)
                {
                    product[i].Show();
                }
            }
        }

        public void DeleteProduct(int key)
        {
            Product[] prod = new Product[size - 1];

            for (int i = 0; i < product.Length; i++)
            {

                if (product[i].ProductInfo.key != key)
                {
                    prod[i] = product[i];
                }
            }
        }


    }
}
