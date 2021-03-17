using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int side1, int side2, int side3)
        {
            this.side_1 = side1;
            this.side_2 = side2;
            this.side_3 = side3;
        }

        public override int area
        {
            get
            {
                if (this.ifLegal())
                {
                    int p = (side_1 + side_2 + side_3) / 2;
                    return (int) Math.Sqrt(p * (p - side_1) * (p - side_2) * (p - side_3));
                }
                else
                {
                    return -1;
                }
            }
        }

        public override bool ifLegal()
        {
            if ((side_1 + side_2 > side_3) && (side_2 + side_3 > side_1) && (side_3 + side_1 > side_2)) return true;
            else return false;
        }

        protected int side_1, side_2, side_3;
    }
}