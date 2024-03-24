using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal partial class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введiть слово:");
                string input = Console.ReadLine();

                Word wordObject = new Word(input);
                int digitCount = wordObject.CountDigits();

                Console.WriteLine($"Кiлькiсть цифр у словi '{input}': {digitCount}");
            Console.ReadKey();
            }
    }   
}
