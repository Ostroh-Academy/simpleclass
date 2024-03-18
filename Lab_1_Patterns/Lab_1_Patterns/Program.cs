using Lab_1_Patterns;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть слово: ");

string? inputWord = Console.ReadLine();

Word wordObject = new Word(inputWord);

int digitCount = wordObject.CountDigits(inputWord);

Console.WriteLine($"Кількість цифр у слові: {digitCount}");
