namespace Lab1
{
    public class Func
    {
        public double a { get; set; }
        public double b { get; set; }
    
        public Func(double _a,double _b)
        {
            a = _a;
            b = _b;
        }
        public double CalculateFunc(double x)
        {
            return Math.Sin(a * x + b);
        }
        public bool IsMaxPoint(double x)
        {
            double n = (a * x + b - Math.PI / 2) / Math.PI;
            return Math.Abs(n - Math.Round(n)) < 1e-10;
        }
    }
}
