using System;

namespace number_two
{
    class Array 
    {
        public int sum;
        public Array()
        {
            sum = 0;
        }
        public void Max(int[] A,int n)
        {
            int max = A[0];
            for (int i=0;i<n;i++)
            {
                if (max < A[i]) max = A[i];
            }
            Console.WriteLine(max);
        }
        public void Min(int[] A, int n)
        {
            int min = A[0];
            for (int i = 0; i < n; i++)
            {
                if (min > A[i]) min = A[i];
            }
            Console.WriteLine(min);
        }
        public void Sum(int[]A,int n)
        {
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + A[i];
            }
            Console.WriteLine(sum);
        }
        public void Average(int[]A,int n)
        {
            double average = (double) sum / n;
            Console.WriteLine(average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int[] numbers = new int[n];

            Console.WriteLine("下面请依次输入数组元素");
            for (int i=0;i<n;i++)
            {
                string input1 = Console.ReadLine();
                numbers[i] = int.Parse(input1);
            }
            Array array=new Array();
            array.Max(numbers,n);
            array.Min(numbers, n);
            array.Sum(numbers, n);
            array.Average(numbers, n);
            Console.ReadLine();
        }
    }
}
