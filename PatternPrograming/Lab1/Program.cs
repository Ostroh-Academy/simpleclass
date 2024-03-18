using System.Security.Cryptography.X509Certificates;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = new Func(1, 2);
            Console.Write("Enter x: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine(func.CalculateFunc(x));
            Console.WriteLine(func.IsMaxPoint(x) ? $"x: {x} is max value" : $"x: {x} isn`t max value");
        }
    }
}
