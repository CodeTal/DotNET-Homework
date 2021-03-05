using System;

namespace Cal_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b, ans;
            char op;
            Console.WriteLine("输入操作数1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入操作符");
            op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("输入操作数2");
            b = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case '+':
                    ans = a + b;
                    break;
                case '-':
                    ans = a - b;
                    break;
                case '*':
                    ans = a * b;
                    break;
                case '/':
                    ans = a / b;
                    break;
                default:
                    ans = 0;
                    break;
            }

            Console.Write("答案是{0}", ans);
        }
    }
}