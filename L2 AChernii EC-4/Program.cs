using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{

    class Program1
        {
            static void Main(string[] args)
            {
                double a, b, x;

                Console.Write("Введiть значення a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Введiть значення b: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Введiть значення x: ");
                x = double.Parse(Console.ReadLine());

                SineFunction sineFunction = new SineFunction(a, b);
                string MaxX = sineFunction.MaxX(x);
                Console.WriteLine($"При а = {a}, b ={b}, x = {x}: {MaxX}\n");
            }
    }
}