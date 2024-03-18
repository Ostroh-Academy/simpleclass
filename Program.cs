namespace ConsoleApp1
{
    internal class Program
    {
        class Cone(List<double> basisCenterCoord, List<double> topCoord, double radius)
        {
            public List<double> BasisCenterCoord { get; set; } = basisCenterCoord;
            public List<double> TopCoord { get; set; } = topCoord;
            public double Radius { get; set; } = radius;

            public double GetCreating() => radius > 0 ? Math.Sqrt(Math.Pow(Math.Sqrt(BasisCenterCoord.Zip(TopCoord, (coord1, coord2) => Math.Pow(coord1 - coord2, 2)).Sum()), 2) + Math.Pow(Radius, 2)) : -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new Cone(new List<double> { 1, 2, 3 }, new List<double> { 4, 5, 6 }, 3).GetCreating());
        }
    }
}
