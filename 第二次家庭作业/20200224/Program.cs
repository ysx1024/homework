using System;

namespace _20200224
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想判断的整数");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int i;
            if (n % 2 == 0)
            {
                Console.WriteLine(2);
            }
            while (n % 2 == 0)
            {
                n = n / 2;
            }
            for (i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i);
                }
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
