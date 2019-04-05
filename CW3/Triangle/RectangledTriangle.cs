using System;

namespace Triangle
{
    class RectangledTriangle : Triangle
    {
        public RectangledTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
        }

        public override double GetSquare()
        {
            return a.CalculateSide(b) * b.CalculateSide(c) / 2;
        }
    }
}
