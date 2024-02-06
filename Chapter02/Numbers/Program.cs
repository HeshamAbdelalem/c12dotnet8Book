namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int decimalNotation = 2_000_000;
            //int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            //int hexadecimalNotation = 0x_001E_8480;

            //Console.WriteLine($"{decimalNotation:N0}");
            //Console.WriteLine($"{binaryNotation:N0}");
            //Console.WriteLine($"{hexadecimalNotation:N0}");


            //Console.WriteLine($"{decimalNotation:X}");
            //Console.WriteLine($"{binaryNotation:X}");
            //Console.WriteLine($"{hexadecimalNotation:X}");

            #region int, double, decimal sizes and numbers they can store

            //Console.WriteLine("********************************");
            //Console.WriteLine($"short uses {sizeof(short)} bytes and can store numbers in the range {short.MinValue:N0} to {short.MaxValue:N0}");
            //Console.WriteLine("********************************");

            //Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");

            //Console.WriteLine("********************************");

            //Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");

            //Console.WriteLine("********************************");
            //Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

            #endregion

            #region compare double and decimal types

            Console.WriteLine("Using Doubles:");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does Not equal 0.3");
            } 

            #endregion
        }
    }
}
