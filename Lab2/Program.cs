using System;

public class Abonent
{
    private string phoneNumber;

    public Abonent(string phoneNumber)
    {
        if (IsValidPhoneNumber(phoneNumber))
        {
            this.phoneNumber = phoneNumber;
        }
        else
        {
            Console.WriteLine("Неправильний формат номера телефону. Будь ласка, введіть номер(у форматі +380*********)");
            Environment.Exit(0);
        }
    }

    private bool IsValidPhoneNumber(string number)
    {
        if (number.Length == 13 && number.StartsWith("+380"))
        {
            foreach (char digitChar in number.Substring(1))
            {
                if (!char.IsDigit(digitChar))
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    public int SumOfDigitsInPhoneNumber()
    {
        int sum = 0;
        foreach (char digitChar in phoneNumber)
        {
            if (char.IsDigit(digitChar))
            {
                sum += (int)Char.GetNumericValue(digitChar);
            }
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть номер телефону у форматі +380*********");

        Abonent abonent = new Abonent(Console.ReadLine());

        int sum = abonent.SumOfDigitsInPhoneNumber();
        Console.WriteLine("Сума цифр телефонного номера: " + sum);
    }
}
