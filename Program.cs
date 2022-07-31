/*using System;
namespace practice_task19
{
    internal class Program
    {
        class GeometricSymbols
        {
            protected int side= 2;
            protected double pi = 3.14;
            protected int length = 3;
            protected int base1 = 12;
            protected int height = 13;

        }
        class Square : GeometricSymbols
        {
            public virtual void area()
            {
                int area = side * side;
                Console.WriteLine("this is sqaure class");
                Console.Write(area);
            }
             public  virtual void perimeter(int i)
            { int a = i;
                int perimeter = a * side * side;
                Console.WriteLine(perimeter);
            }
        }
        class traingle : Square
        {
            public override void area()
            {
                double  n = 1.5;
                double area = n * base1* height;
                Console.WriteLine("this is traingle class");
                Console.WriteLine(area);
            }
            public override void perimeter(int i)
            {
                int perimeter = i + base1 + height;
                Console.WriteLine("traingle class perimeter");
                Console.WriteLine(perimeter);
            }
        }

        static void Main(string[] args)
        {
            traingle obj = new traingle();
            obj.area();
            obj.perimeter(2);




        }
    }
}*/

/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace practice_task19
{
    interface IGeometricSymbols
        {
            void square();
            void triangle();
        }
       public class square1 : IGeometricSymbols
        {
            public void square()
            {

            }
        }
        class traingle1 : IGeometricSymbols
        {
            public void traingle()
            {

            }
        }
        class class1
        {
            public static void Main(string[] args)
            {

            }
        }
    }
}*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace practice_task19
{
    public interface IGeometricSymbol
    {
        void Perimeter();
        void area();
    }
    class Square : IGeometricSymbol
    { private int value;
        private int base1;
        private int height1;
        public void Perimeter()
        {
            value = 4;
            base1 = 5;
            height1 = 9;
        }
        public void perimerter (int i, int j, int k)
            {
            value=i;
            base1=j;
            height1=k;
            int perimeter = i * j * k;
            Console.WriteLine("this is the perimeter of the square");
            Console.WriteLine(perimeter);
            
            }
        public void area()
        {
            value = 5;
            base1 = 5;
        }

        public void area(int i,int j)
        {
            base1=i;
            value = j;
            int area = i * j;
            Console.WriteLine("this is area of the square");
            Console.WriteLine(area);
        }
    }
    class Traingle:IGeometricSymbol
    {
        private int length1;
        private int base2;
        private int height2;
        private double i;
        public void Perimeter()
        {
            length1 = 0; 
            base2=0;
            height2=0;
        }
        public void perimeter(int i, int j, int k)
        {
            length1 = i;     

            base2=j;
            height2 = k;
            int perimeter= i + j + k;
            Console.WriteLine("this is trangle parameter");
            Console.WriteLine(perimeter);
        }
        public void area()
        {
            i = 0.5;
            height2 = 9;
            base2 = 8;
            double area = i * height2 * base2;
            Console.WriteLine("this is area of the Traingle");
            Console.WriteLine(area);
        }
    }
    class class2 { 
           public static void Main(String[] args)
        {
            Traingle obj =new Traingle();
            obj.area();
            obj.perimeter(10,10,10);
        }
     }
}