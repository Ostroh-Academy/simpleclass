using System;

namespace Lab2
{
    class Word
    {
        private string word;

        public Word(string inputWord)
        {
            word = inputWord;
        }

        public int CountDigits()
        {
            int digitCount = 0;
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }
    }
}
