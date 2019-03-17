using System.Linq;
using System.Text;

namespace DEV_2
{
    class WordToTranscription
    {
        private string word;
        private const string vowels = "эоуаеёиыюя";
        private const string consonants = "нтсрлвкмдпбгзйжфхцчшщ";   // from most used to least used
        private const string paired_sonant = "бвдзжг";
        private const string paired_deaf = "пфтсшк";
        private const string y_vowels = "еёюя";
        private const string soundless = "ьъ";

        public WordToTranscription(string word)
        {
            this.word = word;
        }

        public string Translate()
        {
            // О to А
            var transcription = new StringBuilder(word);
            transcription = transcription.Replace("о", "а");
            if (word.Contains("о+"))
            {
                transcription.Replace("а+", "о"); 
            }

            // Remove '+' from both word and transription
            word = word.Replace("+", "");
            transcription.Replace("+", "");

            // Remove 'ъ' и 'ь'
            transcription.Replace("ь", "'");
            transcription.Replace("ъ", "й");

            // Checking first letter for "е, ё, ю, я" and replace if necessary
            for (int i = 0; i < y_vowels.Length; i++)
            {
                if (word.StartsWith(y_vowels[i].ToString()))
                {
                    transcription.Replace(y_vowels[i].ToString(), "й" + vowels[i].ToString(), 0, 1);
                    break;
                }
            }

            for (int i = 0; i < y_vowels.Length; i++)
            {
                if (transcription.ToString().Contains(y_vowels[i]))
                {
                    int index = transcription.ToString().IndexOf(y_vowels[i]);
                    if (vowels.Contains(transcription[transcription.ToString().IndexOf(y_vowels[i]) - 1]) || transcription[transcription.ToString().IndexOf(y_vowels[i]) - 1] ==  '\'')
                    {                        
                        transcription.Remove(index, 1);
                        transcription.Insert(index, "й" + vowels[i].ToString());
                        i--;
                    }
                    else
                    {                        
                        transcription.Remove(index, 1);
                        transcription.Insert(index, "'" + vowels[i].ToString());
                        i--;
                    }
                }
            }
            if (paired_sonant.Contains(transcription[transcription.Length-1]))
            {
                int index = paired_sonant.IndexOf(transcription[transcription.Length - 1]);
                transcription.Remove(transcription.Length - 1, 1);
                transcription.Insert(transcription.Length, paired_deaf[index].ToString());
            }
            return transcription.ToString();
        }
    }
}
