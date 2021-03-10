using System;
using System.Collections.Generic;
using System.Xml;

namespace Homework2
{
    internal class Program
    {
        public static void Q1(int num)
        {
            Stack<int> st = new Stack<int>();
            for (int i = 2; i <= num; i++)
            {
                while ((num % i == 0))
                {
                    st.Push(i);
                    num /= i;
                }
            }

            while (st.Count != 0)
            {
                Console.Write("{0} ", st.Pop());
            }

            Console.WriteLine();
        }

        public static void Q2(int[] array)
        {
            int max = -0x7fffffff;
            int min = 0x7fffffff;
            int ave = 0;
            int sum = 0;
            foreach (var i in array)
            {
                if (i > max) max = i;
                if (i < min) min = i;
                sum += i;
            }

            ave = sum / array.Length;
            Console.WriteLine("max:{0}, min:{1}, ave:{2}, sum:{3}", max, min, ave, sum);
        }

        public static void Q3(int max)
        {
            bool[] isPrime = new bool[max + 1];
            for (int i = 2; i <= max; i++)
            {
                isPrime[i] = true;
            }

            int p_processing = 2;
            while (p_processing <= max)
            {
                if (isPrime[p_processing])
                {
                    for (int i = 2; i * p_processing <= max; i++)
                    {
                        isPrime[i * p_processing] = false;
                    }
                }

                p_processing++;
            }

            Console.WriteLine("Primes are:");
            for (int i = 2; i <= max; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();
        }

        public static void Q4(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int x = row - 1, y = 0;
            while (x >= 0 && y < column)
            {
                int last = matrix[x, y];
                for (int i = x, j = y; i < row && j < column; i++, j++)
                {
                    if (matrix[i, j] != last)
                    {
                        Console.WriteLine("不是托普利茨矩阵");
                        return;
                    }
                }

                if (x > 0) x--;
                else y++;
            }

            Console.WriteLine("是托普利茨矩阵");
        }

        public static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Q1:");
            Program.Q1(80);
            Console.WriteLine();
            //EndQ1
            //Q2
            Console.WriteLine("Q2:");
            int[] arr = {1, 4, 6, 3, 11, 6, 8, 9, 0, 7};
            Program.Q2(arr);
            Console.WriteLine();
            //EndQ2
            //Q3
            Console.WriteLine("Q3:");
            Q3(100);
            Console.WriteLine();
            //EndQ3
            //Q4
            Console.WriteLine("Q4:");
            int[,] mat = {{1, 2, 3, 4}, {5, 1, 2, 3}, {9, 5, 1, 2}};
            Q4(mat);
            //EndQ4
        }
    }
}