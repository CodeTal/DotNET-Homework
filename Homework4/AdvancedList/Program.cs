using System;

namespace AdvancedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new GenericList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Add(4);
            list.Add(5);
            var max = -0x7fffffff;
            var min = 0x7fffffff;
            var sum = 0;

            Action<int> printAction = delegate(int obj) { Console.Write("{0} ", obj); };
            Action<int> maxAction = delegate(int i)
            {
                if (i > max) max = i;
            };
            Action<int> minAction = delegate(int i)
            {
                if (i < min) min = i;
            };
            Action<int> sumAction = delegate(int i) { sum += i; };

            list.Foreach(printAction);
            list.Foreach(maxAction);
            list.Foreach(minAction);
            list.Foreach(sumAction);
            Console.WriteLine();
            Console.WriteLine("Max:{0}; Min:{1}; Sum:{2}", max, min, sum);
        }
    }
}