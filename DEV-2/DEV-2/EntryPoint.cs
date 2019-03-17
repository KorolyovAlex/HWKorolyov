using System;

namespace DEV_2
{
    class EntryPoint
    {
        private static bool LetterCheck(string word)
        {
            bool plus = false;
            foreach (char letter in word)
            {
                if (letter < 192 && letter != '+')
                {
                    Console.WriteLine("Error: use of invalid symbol in line " + word);
                    Console.WriteLine("Only '+' and russian lowercase letters are allowed");
                    return true;
                }
                if (letter == '+')
                {
                    if (plus)
                    {
                        Console.WriteLine("Error: too many '+' in line " + word);
                        return true;
                    }
                    plus = true;
                }
            }
            if (plus)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Error: there is no '+' in line " + word);
                return true;
            }
        }

        static int Main(string[] args)
        {
            foreach (string word in args)
            {
                if (LetterCheck(word))
                {
                    continue;
                }
                var transcription = new WordToTranscription(word);
                Console.WriteLine("Фонема слова " + word + ": " + transcription.Translate());
            }
            return 0;
        }
    }
}
