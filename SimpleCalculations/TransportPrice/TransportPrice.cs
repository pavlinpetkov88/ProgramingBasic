using System;

class TransportPrice
{
    static void Main()
    {
        double km = double.Parse(Console.ReadLine());
        string tarif = Console.ReadLine();
        if (tarif == "day" & km < 20)
        {
            if (tarif == "day") Console.WriteLine(0.70 + (km * 0.79));
        }
        else if (tarif == "night" & km < 20)
        {
            if (tarif == "night") Console.WriteLine(0.70 + (km * 0.90));
        }
        //Taxi

        if (tarif == "day" & km >= 20 & km < 100)
        {
            if (tarif == "day") Console.WriteLine(0.09 * km);
        }
        else if (tarif == "night" & km >= 20 & km < 100)
        {
            if (tarif == "night") Console.WriteLine(0.09 * km);
        }
        //autobus

        if (tarif == "day" & km >= 100 & km <= 5000)
        {
            if (tarif == "day") Console.WriteLine(0.06 * km);
        }
        else if (tarif == "night" & km >= 100 & km <= 5000)
        {
            if (tarif == "night") Console.WriteLine(0.06 * km);
        }
        //train
    }
}

