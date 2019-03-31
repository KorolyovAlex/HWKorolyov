namespace DEV_5
{
    /// <summary>
    /// Interface for flyable objects.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// Set new coordinates for object.
        /// </summary>
        /// <param name="newPoint"> New coordinates for object</param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// Calculates time of flight to (100, 200, 800).
        /// </summary>
        /// <returns> Time of flight</returns>
        double GetFlyTime();

        /// <summary>
        /// Returns name of object.
        /// </summary>
        /// <returns>Name of object</returns>
        string WhoAmI();
    }
}
