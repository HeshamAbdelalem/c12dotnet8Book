
using System.Globalization;
partial class Program
{

    #region TimesTable Function
    //static void TimesTable(byte number, byte size = 12)
    //{
    //    WriteLine($"This is the {number} times table with {size} rows: ");
    //    WriteLine();

    //    for (int row =0; row <= size; row++)
    //    {
    //        WriteLine($"{number} x {row} = {number * row}");
    //    }
    //    WriteLine();
    //}

    #endregion

    #region CalculateTax Function

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08m,
            "DK" or "NO" => 0.25m,
            "GB" or "FR" => 0.2m,
            "HU" => 0.27m,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05m,
            "CA" => 0.825m,
            _ => 0.06m
        };

        return amount * rate;
    }


    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"current culture: {CultureInfo.CurrentCulture.DisplayName}");

    }

  /// <summary>
  /// </summary>
  /// 
  /// <param name="number">number param</param>
  /// 
  /// <returns></returns>

    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (uint i = 1; i <= 150; i++)
        {
            Write($"{CardinalToOrdinal(i)}  ");
        }
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"the factorial function allows only positive numbers , Input: {number}", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
            return number * Factorial(number - 1);

            }
        }
    }

    static void RunFactorial(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i} is too big for 32bit intger");
            } 
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()}   :    {ex.Message}");
            }
        }
    }

    static int FibImperative(uint term)
    {
        if (term == 0)
        {
            throw new ArgumentOutOfRangeException();
        } 
        else if(term ==1)
        {
            return 0;
        } 
        else if(term ==2 )
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    static int FibFunctional(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FibFunctional(term -1) + FibFunctional(term -2)
    };

    static void RunFibFunctional()
    {
        for ( uint i = 1; i <= 30; i ++ )
        {
            WriteLine($"The {CardinalToOrdinal(i)} of the Fibonacci sequence is {FibFunctional(i):N0}");
        }
    }

    #endregion
}

