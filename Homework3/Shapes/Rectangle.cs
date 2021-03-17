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
                if (this.ifLegal())
                {
                    return width * height;
                }
                else
                {
                    return -1;
                }
            }
        }

        public override bool ifLegal()
        {
            return true;
        }

        protected int width, height;
    }
}