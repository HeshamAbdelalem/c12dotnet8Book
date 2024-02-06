namespace Ch03Ex02LoopsAndOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;

            checked
            {
                try
                {
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }

                }
                catch (OverflowException)
                {
                    Console.WriteLine($"there is overflow exception ya bro");
                }
                
                

            }

        }
    }
}
