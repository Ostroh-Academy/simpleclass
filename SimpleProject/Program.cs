namespace SimpleProject
{
    internal static class Program
    {
        private static void Main()
        {
            GetInputData(out var xBaseCenter, out var yBaseCenter, out var zBaseCenter,
                out var xVertex, out var yVertex, out var zVertex, out var radius);

            var cone = new Cone(new Point3D(xBaseCenter, yBaseCenter, zBaseCenter),
                new Point3D(xVertex, yVertex, zVertex),
                radius);
                
            var generatrix = cone.CalculateGeneratrix();
                
            Console.WriteLine($"Generatrix of the cone: {generatrix:F2}");
        }

        private static void GetInputData(out double xBaseCenter, out double yBaseCenter, out double zBaseCenter,
                                  out double xVertex, out double yVertex, out double zVertex,
                                  out double radius)
        {
            GetBaseCenter(out xBaseCenter, out yBaseCenter, out zBaseCenter);
            GetVertex(out xVertex, out yVertex, out zVertex);
            GetRadius(out radius);
        }

        private static void GetBaseCenter(out double x, out double y, out double z)
        {
            Console.WriteLine("Enter the coordinates of the base center of the cone (x, y, z):");
            while (true)
            {
                var input = Console.ReadLine()?.Split(' ');
                if (input is { Length: 3 } &&
                    double.TryParse(input[0], out x) &&
                    double.TryParse(input[1], out y) &&
                    double.TryParse(input[2], out z))
                {
                    break;
                }

                Console.WriteLine("Invalid input format. Please enter in the format: x y z");
            }
        }

        private static void GetVertex(out double x, out double y, out double z)
        {
            Console.WriteLine("Enter the coordinates of the vertex of the cone (x, y, z):");
            while (true)
            {
                var input = Console.ReadLine()?.Split(' ');
                if (input is { Length: 3 } &&
                    double.TryParse(input[0], out x) &&
                    double.TryParse(input[1], out y) &&
                    double.TryParse(input[2], out z))
                {
                    break;
                }

                Console.WriteLine("Invalid input format. Please enter in the format: x y z");
            }
        }

        private static void GetRadius(out double radius)
        {
            Console.WriteLine("Enter the radius of the base of the cone:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
                {
                    break;
                }
                
                Console.WriteLine("Invalid input. Please enter a positive integer number for the radius.");
            }
        }
    }
}