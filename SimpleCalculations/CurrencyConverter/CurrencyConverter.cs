using System;

class CurrencyConverter
{
    static void Main()
    {
        decimal value = decimal.Parse(Console.ReadLine());

        var currency1 = Console.ReadLine();
        var currency2 = Console.ReadLine();

        decimal rate1 = 0.0m;
        decimal rate2 = 0.0m;

        if (currency1 == "BGN")
        {
            rate1 = 1m;
        }
        else if (currency1 == "EUR")
        {
            rate1 = 1.95583m;
        }
        else if (currency1 == "USD")
        {
            rate1 = 1.79549m;
        }
        else if (currency1 == "GBP")
        {
            rate1 = 2.53405m;
        }

        if (currency2 == "BGN")
        {
            rate2 = 1m;
        }
        else if (currency2 == "EUR")
        {
            rate2 = 1.95583m;
        }
        else if (currency2 == "USD")
        {
            rate2 = 1.79549m;
        }
        else if (currency2 == "GBP")
        {
            rate2 = 2.53405m;
        }

        decimal sum = value * (rate1 / rate2);
        Console.WriteLine(Math.Round(sum, 2) + " " + currency2);

    }
}

