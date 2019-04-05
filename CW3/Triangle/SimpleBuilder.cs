namespace Triangle
{
    class SimpleBuilder : Builder
    {
        public SimpleBuilder(Builder nextBuilder)
        {
            this.nextBuilder = nextBuilder;
        }

        public override Triangle BuildTriangle(Point a, Point b, Point c)
        {
            return new SimpleTriangle(a, b, c);
        }
    }
}
