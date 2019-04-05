using System;

namespace Triangle
{
    abstract class Triangle
    {
        protected Point a;
        protected Point b;
        protected Point c;

        public Triangle(Point a, Point b, Point c)
        {
            if ((a.x == b.x && a.y == b.y) ||
                (b.x == c.x && b.y == c.y) ||
                (c.x == a.x && c.y == a.y) ||
                (a.x == b.x && b.x == c.x) ||
                (a.y == b.y && b.y == c.y))
            {
                throw new Exception ("Invalid coordinates - triangle not created");                
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public abstract double GetSquare();       
    }
}
