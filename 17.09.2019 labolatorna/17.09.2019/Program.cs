using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray arr = new RangeOfArray(2, 20);
            int r = 5;
            arr[r] = 5;
            Console.WriteLine(arr[r]);
        }
    }

    class RangeOfArray
    {
        private int[] array;
        private int RangeA = 0, RangeB = 0, size = 0;

        public RangeOfArray()
        {
            array = new int[10];
            RangeA = 0;
            RangeB = 10;
        }

        public RangeOfArray(int index)
        {
            RangeA = 0;
            RangeB = index;
            size = index;
            array = new int[size];
        }

        public RangeOfArray(int A, int B)
        {
            RangeA = A;
            RangeB = B;
            size = 0;
            if (B < 0)
            {
                B *= -1;
            }
            if (A < 0)
            {
                A *= -1;
            }
            size = B + A;
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index > RangeB || index < RangeA)
                {
                    throw new FormatException();
                }
                return array[index - (RangeA)];
            }
            set
            {
                if (index > RangeB || index < RangeA)  
                {
                    throw new FormatException();
                }
                array[index - (RangeA)] = value;   
            }
        }

    }
}
