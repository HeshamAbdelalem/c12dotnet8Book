
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

        if(!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"current culture: {CultureInfo.CurrentCulture.DisplayName}");

    }
    #endregion
}

