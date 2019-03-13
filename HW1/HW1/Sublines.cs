using System;

namespace HW1
{
    public class Sublines
    {
        private string line;

        public Sublines(string line)
        {
            this.line = line;
        }
        

        public void PrintSublines()
        {
            line.ToLower();
            Console.WriteLine("Line: " + line);
            Console.WriteLine("Sublines: ");
            for (int index = 0; index < line.Length; index++)
            {
                for (int j = index + 1; j < line.Length; j++)
                {
                    if (line[j - 1] != line[j])
                    {
                        Console.WriteLine(line.Substring(index, j - index + 1));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}