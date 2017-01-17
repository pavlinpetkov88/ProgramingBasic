using System;

class Harvest
{
    static void Main()
    {

        int lengthOfGrapes = int.Parse(Console.ReadLine());
        double lengthPerOneMeter = double.Parse(Console.ReadLine());
        int needLiter = int.Parse(Console.ReadLine());
        int numberOfWorkers = int.Parse(Console.ReadLine());

        double totalWine = lengthOfGrapes * lengthPerOneMeter;
        double wine = (totalWine * 0.40) / 2.5;

        var leftLiter = Math.Abs(wine - needLiter);
        var literPerWorkers = leftLiter / numberOfWorkers;

        if (wine >= needLiter)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n {1} liters left -> {2} liters per person."
                , Math.Truncate(wine), Math.Ceiling(leftLiter), Math.Ceiling(literPerWorkers));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(leftLiter));
        }
    }
}
