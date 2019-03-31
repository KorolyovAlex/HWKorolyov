namespace DEV_5
{
    /// <summary>
    /// Flyable object SpaceShip. Has constant speed 8000 km/sec
    /// </summary>
    class SpaceShip : IFlyable
    {
        private Point coordinates;
        private const int speed = 8000 * 3600;

        public string WhoAmI() => "Spaceship";

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
