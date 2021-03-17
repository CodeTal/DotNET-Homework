using System;
using Shapes;

namespace Factory
{
    public class MyFactory
    {
        //shapeParams为传入的形状的相关参数，如长宽，半径等
        public static Shape Manufacture(String ShapeName, params int[] shapeParams)
        {
            switch (ShapeName)
            {
                case "Rectangle":
                    return new Rectangle(shapeParams[0], shapeParams[1]);
                case "Square":
                    return new Square(shapeParams[0]);
                case "Triangle":
                    return new Triangle(shapeParams[0], shapeParams[1], shapeParams[2]);
                case "Circle":
                    return new Circle(shapeParams[0]);
                default:
                    return null;
            }
        }
    }
}