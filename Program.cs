using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  методу обчислення довжини вектора
            Console.WriteLine("Введіть координати вектора (x y z):");
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double z = double.Parse(input[2]);

            Vector3d vector = new Vector3d(x, y, z);
            double length = vector.CalculateLength();
            Console.WriteLine($"Довжина вектора: {length}");
        }
    }
}
