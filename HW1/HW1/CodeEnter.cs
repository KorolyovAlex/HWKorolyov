using System;

namespace HW1
{
    class CodeEnter
    {
        static void Main(string[] args)
        {
            if (args[0].Length < 2) // Line length check
            {
                Console.WriteLine("Error: not enough symbols in line");
                return;
            }
            Sublines.PrintSublines(args[0]);    // Takes only first argument
            Console.ReadKey();
        }
    }
}