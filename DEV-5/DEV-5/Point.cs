using System;

namespace DEV_5
{
    /// <summary>
    /// Struct for flyable object, that contains coordinates of object
    /// </summary>
    struct Point
    {
        int coordinateX;
        int coordinateY;
        int coordinateZ;

        public Point(int x = 0, int y = 0, int z = 0)
        {
            coordinateX = x;
            coordinateY = y;
            coordinateZ = z;
        }

        public double GetDistance(Point newPoint)
        {
            return Math.Sqrt(Math.Pow(newPoint.coordinateX - coordinateX, 2) + Math.Pow(newPoint.coordinateY - coordinateY, 2) + Math.Pow(newPoint.coordinateZ - coordinateZ, 2));     
        }
    }
}
