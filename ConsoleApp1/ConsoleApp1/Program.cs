using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        PeretvorennyaPloshchyni peretvorennya = new PeretvorennyaPloshchyni();

        double a, b, c, x, y, x2, y2;
        Console.WriteLine("Введіть коефіцієнти a, b, c:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть координати першої точки (x1, y1):");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть координати другої точки (x2, y2):");
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        bool peretvoryuyutsia = peretvorennya.Peretvoryuyutsia(a, b, c, x, y, x2, y2);

        if (peretvoryuyutsia)
        {
            Console.WriteLine("Так, точки переводяться одна в одну.");
        }
        else
        {
            Console.WriteLine("Ні, точки не переводяться одна в одну.");
        }
    }
}

class PeretvorennyaPloshchyni
{
    public bool Peretvoryuyutsia(double a, double b, double c, double x1, double y1, double x2, double y2)
    {
        double y2_obch = a + b * x2 + c;
        return y1 == y2_obch;
    }
}
