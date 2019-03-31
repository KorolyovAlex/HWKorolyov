using System;

namespace DEV_5
{
    /// <summary>
    /// Flyable object Bird.
    /// </summary>
    class Bird : IFlyable
    {
        private Point coordinates;
        private int speed;

        /// <summary>
        /// Constructor for the class. Set random value from 0 to 20 for speed.
        /// </summary>
        public Bird()
        {
            Random rand = new Random();
            speed = rand.Next(0, 21);
        }

        public string WhoAmI() => "Bird";
        

        public void FlyTo(Point newPoint)
        {
            coordinates = newPoint;
        }

        public double GetFlyTime()
        {
            return coordinates.GetDistance(new Point(100, 200, 800)) / speed;
        }
    }
}
