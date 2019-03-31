using System;
namespace DEV_5
{
    /// <summary>
    /// Flyable object Plane. Has start speed 200 km/h that change during the flight (+10 km/h for every 10 km of flight)
    /// </summary>
    class Plane : IFlyable
    {
        private Point coordinates;
        private readonly int speed = 200;

        public string WhoAmI() => "Plane";        

        public void FlyTo(Point newPoint)
        {
            coordinates = newPoint;
        }

        public double GetFlyTime()
        {
            double distance = coordinates.GetDistance(new Point(100, 200, 800));
            double time = 0;
            int counter = 0;
            while (distance > 10)
            {
                time += 10 / (double)(speed + counter * 10);
                counter++;
                distance -= 10;
            }
            time += distance / (double)(speed + counter * 10);
            return time;
        }
    }
}
