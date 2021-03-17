using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int area
        {
            get
            {
                if (this.isLegal())
                {
                    return (int) (Math.PI * (double) radius * (double) radius);
                }
                else
                {
                    return -1;
                }
            }
        }

        public override bool isLegal()
        {
            return true;
        }


        protected int radius;
    }
}