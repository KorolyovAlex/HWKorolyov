using System;

namespace Triangle
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Builder equalBuilder = new EquilateralBuilder(
                                       new RectangledBuilder(
                                       new SimpleBuilder(null)));
                Triangle triangle = equalBuilder.BuildTriangle(new Point(5, 1), new Point(2, 3), new Point(7, 9));
                Console.WriteLine($"{triangle.GetType().Name} is created");
                Console.WriteLine($"Triangle square: {triangle.GetSquare()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
        }
    }
}
