namespace Triangle
{
    class RectangledBuilder : Builder
    {
        public RectangledBuilder(Builder nextBuilder)
        {
            this.nextBuilder = nextBuilder;
        }

        public override Triangle BuildTriangle(Point a, Point b, Point c)
        {
            Vector ab = new Vector(a, b);
            Vector bc = new Vector(b, c);
            Vector ca = new Vector(c, a);
            if (ab.GetScalarProduct(bc) == 0)
            {
                return new RectangledTriangle(a, b, c);
            }
            if (bc.GetScalarProduct(ca) == 0)
            {
                return new RectangledTriangle(b, c, a);
            }
            if (ca.GetScalarProduct(ab) == 0)
            {
                return new RectangledTriangle(c, a, b);
            }
            if (nextBuilder != null)
            {
                return nextBuilder.BuildTriangle(a, b, c);
            }
            return null;
        }
    }
}
