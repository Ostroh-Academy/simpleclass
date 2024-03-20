using System;

class Person
{
    private int day;
    private int month;
    private int year;

    public Person(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public bool IsBirthdayLucky()
    {
        int sum = day + month + year;
        int remainder = sum % 7;
        return (sum / 7 == remainder);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Введення даних про день народження
        Console.WriteLine("Введіть день народження:");
        int day = Convert.ToInt32(Console.ReadLine());

        // Введення даних про місяць народження
        Console.WriteLine("Введіть місяць народження:");
        int month = Convert.ToInt32(Console.ReadLine());

        // Введення даних про рік народження
        Console.WriteLine("Введіть рік народження:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Створення об'єкта класу Person з введеними даними
        Person person = new Person(day, month, year);

        // Перевірка, чи народилася людина в щасливий день
        if (person.IsBirthdayLucky())
        {
            Console.WriteLine("Ця людина народилася в щасливий день!");
        }
        else
        {
            Console.WriteLine("Ця людина народилася не в щасливий день.");
        }
    }
}