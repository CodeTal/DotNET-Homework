namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }

        public override bool ifLegal()
        {
            if (this.width == this.height) return true;
            else return false;
        }
    }
}