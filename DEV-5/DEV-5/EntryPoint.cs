using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// Entry point of the program. Program creates object and calculates time to fly from one point to another.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point of program.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Plane plane = new Plane();
            SpaceShip spaceship = new SpaceShip();
            Console.WriteLine("Bird flytime: " + bird.GetFlyTime() + " hours");
            Console.WriteLine("Plane flytime: " + plane.GetFlyTime() + " hours");
            Console.WriteLine("Spaceship flytime: " + spaceship.GetFlyTime() + " hours");
            Point point = new Point();
        }
    }
}
