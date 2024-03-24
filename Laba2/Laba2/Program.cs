using Laba2;

double a3 = ReadCoeficcientFromConsole("a3");
double a2 = ReadCoeficcientFromConsole("a2");
double a1 = ReadCoeficcientFromConsole("a1");
double a0 = ReadCoeficcientFromConsole("a0");

CubicPolynomial polynomial = new CubicPolynomial(a3, a2, a1, a0);

Console.Write("Введіть точку a відрізку [a, b] >: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введіть точку b відрізку [a, b] >: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введіть рівень точності епсілон >: ");
double epsilon = double.Parse(Console.ReadLine());

double minValue = polynomial.FindMinimum(a, b, epsilon);
Console.WriteLine($"Мінімальне значення на відрізку [{a}, {b}] з точністю {epsilon}: {minValue}");

double ReadCoeficcientFromConsole(string coefName)
{
    Console.Write($"Введіть коефіцієнт {coefName}>: ");
    return double.Parse(Console.ReadLine());
}