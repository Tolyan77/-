using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._09._2019_operator_perez
{
    class Rectangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle()
        {
            SideA = 0;
            SideB = 0;
        }

        public Rectangle(int a, int b)
        {
            SideA = a;
            SideB = b;
        }

        public override string ToString()
        {
            return $"Side A : {SideA}\n\tSide B :{SideB}";
        }

        public override bool Equals(object obj)
        {
            var rectangle = obj as Rectangle;
            return rectangle != null &&
                   SideA == rectangle.SideA &&
                   SideB == rectangle.SideB;
        }

        public override int GetHashCode()
        {
            var hashCode = 999451561;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
            hashCode = hashCode * -1521134295 + SideB.GetHashCode();
            return hashCode;
        }

        public static Rectangle operator ++(Rectangle p)
        {
            p.SideA++;
            p.SideB++;
            return p;
        }

        public static Rectangle operator --(Rectangle p)
        {
            p.SideA--;
            p.SideB--;
            return p;
        }

        public static Rectangle operator +(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                SideA = p1.SideA + p2.SideA,
                SideB = p1.SideB + p2.SideB
            };
            return p3;
        }​

        public static Rectangle operator -(Rectangle p1, Rectangle p2)
        { 
            Rectangle p3 = new Rectangle
            {
                SideA = p1.SideA - p2.SideA,
                SideB = p1.SideB - p2.SideB
            }; 
            return p3;
        }​

        public static Rectangle operator *(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                SideA = p1.SideA * p2.SideA,
                SideB = p1.SideB * p2.SideB
            };
            return p3;
        }

        public static Rectangle operator /(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle
            {
                SideA = p1.SideA / p2.SideA,
                SideB = p1.SideB / p2.SideB
            };
            return p3;
        }

        public static bool operator !=(Rectangle p1, Rectangle p2)
        {
            return p1.Equals(p2);
        }​
    }

    class Square
    {
        public int Side { get; set; }

        public Square()
        {
            Side = 0;
        }

        public Square(int side)
        {
            Side = side;
        }

        public override string ToString()
        {
            return $"Sides : {Side}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Square operator ++(Square p)
        { 
            p.Side++;
            return p;
        }

        public static Square operator --(Square p)
        {
            p.Side--;
            return p;
        }

        public static Square operator +(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                Side = p1.Side + p2.Side
            };
            return p3;
        }​

        public static Square operator -(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                Side = p1.Side - p2.Side
            };
            return p3;
        }​

         public static Square operator *(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                Side = p1.Side * p2.Side
            };
            return p3;
        }

        public static Square operator /(Square p1, Square p2)
        {
            Square p3 = new Square
            {
                Side = p1.Side / p2.Side
            };
            return p3;
        }

    }
}
