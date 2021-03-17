using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Shapes;
using Factory;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(MyFactory.Manufacture("Rectangle", 3, 4));
            shapes.Add(MyFactory.Manufacture("Square", 6));
            shapes.Add(MyFactory.Manufacture("Circle", 3));
            shapes.Add(MyFactory.Manufacture("Triangle", 3, 4, 5));
            shapes.Add(MyFactory.Manufacture("Rectangle", 3, 4));
            shapes.Add(MyFactory.Manufacture("Circle", 5));
            shapes.Add(MyFactory.Manufacture("Square", 4));
            shapes.Add(MyFactory.Manufacture("Triangle", 3, 4, 2));
            shapes.Add(MyFactory.Manufacture("Rectangle", 3, 4));
            shapes.Add(MyFactory.Manufacture("Square", 7));
            int areaSum = 0;
            foreach (var shape in shapes)
            {
                if (shape.isLegal()) areaSum += shape.area;
            }

            Console.WriteLine("总面积：{0}", areaSum);
        }
    }
}