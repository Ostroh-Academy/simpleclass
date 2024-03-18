namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArifmeticalProgression arifmeticalProgression = new ArifmeticalProgression(2,3,2);
            double sum = arifmeticalProgression.SumOfProgression();
            Console.WriteLine(sum);
        }
    }
}
