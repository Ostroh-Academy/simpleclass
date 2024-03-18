using Patterns_Lab2;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person("Name", new DateTime(1990, 10, 15));

        if (person.IsLuckyDay())
        {
            Console.WriteLine($"{person.Name} народився в щасливий день!");
        }
        else
        {
            Console.WriteLine($"{person.Name} не народився в щасливий день.");
        }
    }
}