using System;

namespace number_two
{
    interface Shape
    {
        double Area();
        bool Legitimate();
    }
    class Rectangle : Shape
    {
        public double length;
        public double width;
        private bool legitimate;
        public Rectangle(double m, double n)
        {
            length = m;
            width = n;
        }
        public bool Legitimate()
        {
            if (length > 0 && width > 0)
                return legitimate = true;
            else
                return legitimate = false;
        }
        public double Area()
        {
                double area = length * width;
            return area;
        }
    }
    class Square : Shape
    {
        public double side;
        private bool legitimate;

        public Square(double x)
        {
            side = x;
        }
        public double Area()
        {
                double area = side * side;
            return area;
        }
        public bool Legitimate()
        {
            if (side > 0)
                return legitimate = true;
            else
                return legitimate = false;
        }
    }
    class Triangle : Shape
    {
        public double a, b, c;
        private bool legitimate;

        public Triangle(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }
        public bool Legitimate()
        {
            if ((a - b) <= c)
                return legitimate = false;
            else
                return legitimate = true;
        }
        public double Area()
        {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
    class ShapeFactory
    {
        public static Random random()
        {
            Random R = new Random(Guid.NewGuid().GetHashCode());
            return R;
        }
        public static Shape getShape(int n)
        {
            Shape shape = null;
            if (n==0)
            {
                Random rd1 = new Random();
                int x,y;
                x = rd1.Next(1,10);
                y = rd1.Next(1,10);
                shape = new Rectangle(x,y);
            }
            else if (n==1)
            {
                Random rd2 = new Random();
                int side = rd2.Next(1, 10);
                shape = new Square(side);
            }
            else if (n==2)
            {
                Random rd3 = new Random();
                int a, b, c;
                a = rd3.Next(1, 10);
                b = rd3.Next(1, 10);
                c = rd3.Next(1, 10);
                shape = new Triangle(a,b,c);
            }
            return shape;
        }
    }
    class Program
    {
        public static Random random()
        {
            Random R = new Random(Guid.NewGuid().GetHashCode());
            return R;
        }
        static void Main(string[] args)
        {
            Shape shape;
            double areas = 0;
            for(int i = 0;i < 10;i++)
            {
                shape = ShapeFactory.getShape(ShapeFactory.random().Next(0,2));
                if (shape.Legitimate())
                {
                    areas += shape.Area();
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine(areas);
            Console.ReadLine();
        }
    }
}
