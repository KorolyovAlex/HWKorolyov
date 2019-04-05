using System;


namespace Triangle
{
    class EquilateralBuilder : Builder
    {
        public EquilateralBuilder(Builder nextBuilder)
        {
            this.nextBuilder = nextBuilder;
        }

        public override Triangle BuildTriangle(Point a, Point b, Point c)
        {
            double ab = a.CalculateSide(b);
            double bc = b.CalculateSide(c);
            double ca = c.CalculateSide(a);
            if (Math.Abs(bc - ab) < double.Epsilon && Math.Abs(ca - bc) < double.Epsilon)
            {
                return new EquilateralTriangle(a, b, c);
            }
            else if (nextBuilder != null)
            {
                return nextBuilder.BuildTriangle(a, b, c);
            }
            return null;
        }
    }
}
