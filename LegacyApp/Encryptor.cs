using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public class Encryptor
    {
        public String CryptWord(String word)
        {
            if (word.Contains(" "))
            {
                throw new ArgumentException();
            }

            char[] wordArray = word.ToCharArray();

            String newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                int charValue = wordArray[i];
                newWord += Convert.ToChar(charValue + 2);
            }

            return newWord;
        }

        public String CryptWordToNumbers(String word)
        {
            if (word.Contains(" "))
                throw new ArgumentException();

            char[] wordArray = word.ToCharArray();

            String newWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                int charValue = wordArray[i];
                newWord += (charValue + 2).ToString();
            }

            return newWord;
        }

        public String CryptWord(String word, String charsToReplace)
        {
            if (word.Contains(" "))
            {
                throw new ArgumentException();
            }
            char[] wordArray = word.ToCharArray();
            char[] replacement = charsToReplace.ToCharArray();
            char[] result = word.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 0; j < replacement.Length; j++)
                {
                    if (replacement[j] == wordArray[i])
                    {
                        int charValue = wordArray[i];
                        result[i] = (char)(charValue + 2);
                    }
                }
            }
            return result.ToString();
        }

        public String CryptSentence(String sentence)
        {
            char[] sentenceArray = sentence.ToCharArray();
            String newWord = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                int charValue = sentenceArray[i];
                newWord += Convert.ToChar(charValue + 2);
            }
            return newWord;
        }

        public String[] GetWords(String sentence)
        {
            return sentence.Split(' ');
        }

        public void PrintWords(String sentence)
        {
            String[] words = GetWords(sentence);
            foreach (String word in words)
            {
                Console.Write("<" + word + ">");
            }
        }
    }
}
