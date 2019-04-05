namespace Triangle
{
    abstract class Builder
    {
        public Builder nextBuilder;
        public abstract Triangle BuildTriangle(Point a, Point b, Point c);
    }
}
