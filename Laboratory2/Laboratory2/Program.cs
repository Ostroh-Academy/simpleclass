using System.Text;
using Laboratory2.Core;

namespace Laboratory2;

internal static class Program
{
    private static void Main()
    {
        InitConsole();
        
        Line line = GetLineInput();
        Point point = GetPointInput();
        Point point2 = GetPointInput();

        bool[] pointsBelonging = CalculatePointsBelongToLine(line, point, point2);
        ShowResult(pointsBelonging);
    }

    private static void InitConsole()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
    }

    private static Line GetLineInput()
    {
        Console.WriteLine("Введіть коефіцієнти A, B, C для рівняння прямої Ax + By + C = 0...");
        GetInput("A: ", out int a);
        GetInput("B: ", out int b);
        GetInput("C: ", out int c);
        return new Line(a, b, c);
    }

    private static Point GetPointInput()
    {
        Console.WriteLine("Введіть координати точки (x, y)...");
        GetInput("x: ", out int x);
        GetInput("y: ", out int y);
        return new Point(x, y);
    }

    private static bool[] CalculatePointsBelongToLine(Line line, params Point[] points) =>
        points
            .Select(line.Belongs)
            .ToArray();

    private static void ShowResult(IReadOnlyList<bool> pointsBelonging)
    {
        Console.WriteLine("\nРезультат:");
        for(int i = 0; i < pointsBelonging.Count; i++)
        {
            bool belongs = pointsBelonging[i];
            Console.WriteLine($"{i + 1}) {(belongs ? "Так" : "Ні" )}");
        }
    }

    private static void GetInput(string message, out int input)
    {
        do
            Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out input)); 
    }
}