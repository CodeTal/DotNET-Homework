namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override int area
        {
            get
            {
                if (this.isLegal())
                {
                    return width * height;
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

        protected int width, height;
    }
}