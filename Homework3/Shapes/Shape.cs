using System;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract int area { get; } //若形状不合法，则返回-1

        public abstract bool ifLegal();
    }
}