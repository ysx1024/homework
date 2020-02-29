using System;

namespace numberthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[99];
            for (int i=2;i<=100;i++)
            {
                A[i - 2] = i;
            }
            for (int j=2;j<=7;j++)
            {
                for(int k = 0; k < 99; k++)
                {
                    if (A[k] % j == 0&&A[k]!=j)
                        A[k] = 0;
                }
            }
            for (int m = 0; m < 99; m++)
            {
                if (A[m] != 0)
                    Console.WriteLine(A[m]);
            }
            Console.ReadLine();
        }
    }
}
