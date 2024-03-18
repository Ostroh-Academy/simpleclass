namespace Laboratory2.Core;

internal sealed class Line
{
    public readonly int A;
    public readonly int B;
    public readonly int C;
    
    public Line(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool Belongs(Point point) =>
        (double)A * point.X + (double)B * point.Y + C == 0;

    public override string ToString() =>
        $"Line: {A}x + {B}y + {C} = 0";
}