namespace Patterns_Lab2;

public class Person
{
    private string _name;
    private DateTime _dateOfBirth;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public Person(string name, DateTime dateOfBirth)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public bool IsLuckyDay()
    {
        int day = DateOfBirth.Day;
        int month = DateOfBirth.Month;
        int year = DateOfBirth.Year;

        return (CalculateSumOfDigits(day) % 7 == CalculateSumOfDigits(month) % 7 &&
                CalculateSumOfDigits(day) % 7 == CalculateSumOfDigits(year) % 7);
    }

    private int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}