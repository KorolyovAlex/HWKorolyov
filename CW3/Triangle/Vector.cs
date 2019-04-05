using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    struct Vector
    {
        public int x;
        public int y;

        public Vector(Point a, Point b)
        {
            x = b.x - a.x;
            y = b.y - a.y;
        }

        public int GetScalarProduct(Vector vector)
        {
            return x * vector.x + y * vector.y;
        }
    }
}
