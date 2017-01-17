using System;

class Exam3
{
    static void Main()
    {
        var hrizantemiKupeni = double.Parse(Console.ReadLine());

        var RoziKupeni = int.Parse(Console.ReadLine());
        var laletaKupeni = int.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        var ifTheDayIsHoliday = Console.ReadLine();

        var hrizamtemi = 0d;
        var rosesPrice = 0d;
        var tulipsPrice = 0d;

        if (season == "Spring" || season == "Summer")
        {
            hrizamtemi = 2.00;
            rosesPrice = 4.10;
            tulipsPrice = 2.50;
        }
        else if (season == "Winter" || season == "Autumn")
        {
            hrizamtemi = 3.75;
            rosesPrice = 4.50;
            tulipsPrice = 4.15;
        }
        double sumPriceHrizantemi = hrizantemiKupeni * hrizamtemi;
        double sumPriceRozi = rosesPrice * RoziKupeni;
        double sumPriceLaleta = tulipsPrice * laletaKupeni;
        double sumFlowers = laletaKupeni + RoziKupeni + hrizantemiKupeni;
        double sum = sumPriceHrizantemi + sumPriceLaleta + sumPriceRozi;

        if (ifTheDayIsHoliday == "Y")
        {
            sum = sum + (sum * 0.15);
        }

        if (laletaKupeni > 7 && season == "Spring")
        {
            sum = sum - (sum * 0.05);
        }
        if (RoziKupeni >= 10 && season == "Winter")
        {
            sum = sum - (sum * 0.10);
        }

        if (sumFlowers > 20)
        {
            sum = sum - (sum * 0.20);
        }
        Console.WriteLine("{0:f2}", sum + 2);

    }
}
