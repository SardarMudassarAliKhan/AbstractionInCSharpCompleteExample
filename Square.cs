namespace AbstractionInCSharpCompleteExample
{
    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public double GetSideLength()
        {
            return Length;
        }
    }
}
