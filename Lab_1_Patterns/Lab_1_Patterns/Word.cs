namespace Lab_1_Patterns
{
    public class Word
    {
        public string word { get; private set; }
        public Word(string inputWord)
        {
            word = inputWord;
        }

        public int CountDigits(string word)
        {
            if (word.Length == 0)
            {
                Console.WriteLine("Ця строка пуста");
                return 0;
            }

            int digitCount = 0;
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }

    }
}
