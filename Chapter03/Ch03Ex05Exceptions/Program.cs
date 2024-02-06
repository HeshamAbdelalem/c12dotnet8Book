namespace Ch03Ex05Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 255:");
            string? inputNumber01 = Console.ReadLine();

            Console.Write("Enter another number between 0 and 255:");
            string? inputNumber02 = Console.ReadLine();

            try
            {
                int? num01 = int.Parse(inputNumber01);
                int? num02 = int.Parse(inputNumber02);

                Console.WriteLine($"{num01} divided by {num02} is {num01 / num02}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("DivideByZero is not allowed!");
            }

            catch (FormatException)
            {
                Console.WriteLine($"FormatException: Input string was not in a correct format.");
            }
        }
    }
}
