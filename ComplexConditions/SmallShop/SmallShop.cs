using System;

class SmallShop
{
    static void Main()
    {
        var product = Console.ReadLine().ToLower();
        var town = Console.ReadLine().ToLower();
        var quality = double.Parse(Console.ReadLine());
        if (town == "sofia")
        {
            if (product == "coffee") Console.WriteLine(0.50 * quality);
            if (product == "water") Console.WriteLine(0.80 * quality);
            if (product == "beer") Console.WriteLine(1.20 * quality);
            if (product == "sweets") Console.WriteLine(1.45 * quality);
            if (product == "peanuts") Console.WriteLine(1.60 * quality);
        }

        if (town == "plovdiv")
        {
            if (product == "coffee") Console.WriteLine(0.40 * quality);
            if (product == "water") Console.WriteLine(0.70 * quality);
            if (product == "beer") Console.WriteLine(1.15 * quality);
            if (product == "sweets") Console.WriteLine(1.30 * quality);
            if (product == "peanuts") Console.WriteLine(1.50 * quality);
        }

        if (town == "varna")
        {
            if (product == "coffee") Console.WriteLine(0.45 * quality);
            if (product == "water") Console.WriteLine(0.70 * quality);
            if (product == "beer") Console.WriteLine(1.10 * quality);
            if (product == "sweets") Console.WriteLine(1.35 * quality);
            if (product == "peanuts") Console.WriteLine(1.55 * quality);
        }
    }
}
