namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 2.5;

            double Answer = Add(a, b);
            WriteLine($"{a} + {b} = {Answer}");
            ReadLine();
        }

        static double Add(double a, double b) => a + b;
    }
}
