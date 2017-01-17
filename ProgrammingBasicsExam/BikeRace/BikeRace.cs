using System;

class BikeRace
{
    static void Main()
    {

        int youngBicycler = int.Parse(Console.ReadLine());
        int oldBicycler = int.Parse(Console.ReadLine());
        string typeLayout = Console.ReadLine();

        double price = 0;
        double comission = 0.05;
        int sumBicycler = youngBicycler + oldBicycler;

        if (typeLayout == "cross-country" && sumBicycler >= 50) price = ((8 - 0.25 * 8) * youngBicycler) + ((9.50 - 0.25 * 9.50) * oldBicycler);
        else if (typeLayout == "trail") price = (5.50 * youngBicycler) + (7 * oldBicycler);
        else if (typeLayout == "cross-country") price = (8 * youngBicycler) + (9.50 * oldBicycler);
        else if (typeLayout == "downhill") price = (12.25 * youngBicycler) + (13.75 * oldBicycler);
        else if (typeLayout == "road") price = (20.00 * youngBicycler) + (21.50 * oldBicycler);


        double moneyLeft = price - comission * price;

        Console.WriteLine("{0:f2}", moneyLeft);

    }
}
