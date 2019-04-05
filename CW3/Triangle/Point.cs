using System;

namespace Triangle
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSide(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x - x, 2) + Math.Pow(point.y - y, 2));
        }
    }
}
