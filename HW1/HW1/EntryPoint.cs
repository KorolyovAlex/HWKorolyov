using System;

namespace HW1
{
    class EntryPoint
    {
        static int Main(string[] args)
        {
            foreach (string line in args)
            {
                if (line.Length < 2) // Line length check
                {
                    Console.WriteLine("Error: not enough symbols in line \"" + line + "\"");
                    continue;
                }
                var Subline = new Sublines(line);
                Subline.PrintSublines();
            }
            return 0;
        }
    }
}