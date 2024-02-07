namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("before parsing");
            //Console.WriteLine("What's ur age?");

            //string? ageString = Console.ReadLine();

            //try
            //{
            //    if (ageString == "")
            //    {
            //        Console.WriteLine("you didn't write anything");
            //    }
            //    else
            //    {
            //        int age = int.Parse(ageString!);
            //        Console.WriteLine($"You are {ageString} years old");

            //    }
            //}
            //catch (FormatException) {
            //    Console.WriteLine("The age you entered is not a valid number format.");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("you age is valid number but it's either too big or too small");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.GetType()} says : {ex.Message}");
            //}

            //Console.WriteLine("after parsing");



            //Console.Write("Enter an amount: ");
            //string? amount = Console.ReadLine();
            //if (string.IsNullOrEmpty(amount))
            //{
            //    Console.WriteLine("amount cannot be empty");
            //    return;
            //};

            //try
            //{
            //    decimal amountValue = int.Parse(amount);
            //    Console.WriteLine($"The amount you entered is : {amountValue:C}");
            //} 
            //catch (FormatException ) when (amount.Contains("$"))
            //{
            //    Console.WriteLine("please don't enter a '$' sign, Just the number");
            //} 
            //catch (FormatException)
            //{
            //    Console.WriteLine("amounts must be in digits only");
            //}


            // Overflow Exceptions
            //checked
            //{
            //    try
            //    {
            //        int x = int.MaxValue - 1;
            //        Console.WriteLine($"{x:0,000}");
            //        x++;
            //        Console.WriteLine($"{x:0,000}");
            //        x++;
            //        Console.WriteLine($"{x:0,000}");


            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("the number is too big");
            //    }
            //}

            #region Disable complier ovreflow checks with the unchecked statement

            //unchecked
            //{
            //    int y = int.MaxValue + 1;
            //    Console.WriteLine(y);
            //    y--;
            //    Console.WriteLine(y);
            //    y--;
            //    Console.WriteLine(y);
            //}


            #endregion


            for (; ; )
            {
                Console.WriteLine("loop");
            };


        }


    }
}
