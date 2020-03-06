using System;

namespace number_one
{
    interface Shape
    {
        void Legitimate();
        void Area();
    }
    class Rectangle:Shape
    {
        public double length;
        public double width;
        private bool legitimate;
        public Rectangle(double m,double n)
        {
            length = m;
            width = n;
        }
        public void Legitimate()
        {
            if (length == width || length <= 0 || width <= 0)
                legitimate = false;
            else
                legitimate = true;
        }
        public void Area()
        {
            if (legitimate)
            {
                double area = length * width;
                Console.WriteLine("该长方形合法，面积为" + area);
            }
            else
                Console.WriteLine("该长方形不合法");
        }
    }
    class Square:Shape
    {
        public double side;
        private bool legitimate;

        public Square(double x)
        {
            side = x;
        }
        public void Legitimate()
        {
            if (side <= 0)
                legitimate = false;
            else
                legitimate = true;
        }
        public void Area()
        {
            if (legitimate)
            {
                double area = side*side;
                Console.WriteLine("该正方形合法，面积为" + area);
            }
            else
                Console.WriteLine("该正方形不合法");
        }
    }
    class Triangle:Shape
    {
        public double a, b, c;
        private bool legitimate;

        public Triangle(double x,double y,double z)
        {
            a = x;
            b = y;
            c = z;
        }
        public void Legitimate()
        {
            if ((a + b) <= c || a <= 0 || b <= 0 || c <= 0)
                legitimate = false;
            else
                legitimate = true;
        }
        public void Area()
        {
            if (legitimate)
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("该三角形合法，面积为" + area);
            }
            else
                Console.WriteLine("该三角形不合法");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(13,14);
            rectangle.Legitimate();
            rectangle.Area();

            Square square = new Square(10);
            square.Legitimate();
            square.Area();

            Triangle triangle = new Triangle(3,4,5);
            triangle.Legitimate();
            triangle.Area();

            Console.ReadLine();
        }
    }
}
