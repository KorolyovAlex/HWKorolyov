using System;

namespace Triangle
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
        }

        public override double GetSquare()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(a.CalculateSide(b), 2);
        }
    }
}
