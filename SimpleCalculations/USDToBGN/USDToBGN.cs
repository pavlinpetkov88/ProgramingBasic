using System;

class USDToBGN
{
    static void Main()
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal priceofusd = 1.79549m;
        decimal sum = usd * priceofusd;
        decimal result = Math.Round(sum, 2);
        Console.WriteLine("{0} BGN", result );
    }
}
