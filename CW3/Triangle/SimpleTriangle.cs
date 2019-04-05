using System;

namespace Triangle
{
    class SimpleTriangle : Triangle
    {
        public SimpleTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
        }

        public override double GetSquare()
        {
            double ab = a.CalculateSide(b);
            double bc = b.CalculateSide(c);
            double ca = c.CalculateSide(a);
            double p = (ab + bc + ca) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }
    }
}
