namespace Practice_1
{
    internal class Program
    {
        public class Plane
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double D { get; set; }

            public Plane(double A, double B, double C, double D)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
            }
            public void IsPointOnPlane(double x, double y, double z)
            {
                if (A * x + B * y + C * z + D == 0)
                {
                    Console.WriteLine("Точка належить площині");
                    
                }
                else
                {
                    Console.WriteLine("Точка не належить площині");
                    
                }
            }
        }
        static void Main(string[] args)
        {
            double A, B, C, D, x, y, z;
            Console.WriteLine("Введіть координати площини для рівняння виду: Ax + By + Cz + D = 0");
            Console.WriteLine("Введіть координату A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть координату B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть координату C:");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть координату D:");
            D = double.Parse(Console.ReadLine());

            Plane plane = new Plane(A, B, C, D);
            Console.WriteLine("\n");
            Console.WriteLine("Введіть координату x для точки:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть координату y для точки:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть координату z для точки:");
            z = double.Parse(Console.ReadLine());
            plane.IsPointOnPlane(x,y,z);
        }
    }

}
