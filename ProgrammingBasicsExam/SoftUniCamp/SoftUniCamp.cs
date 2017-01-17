using System;

class SoftUniCamp
{
    static void Main()
    {

        int countOfGroup = int.Parse(Console.ReadLine());

        int totalSumOfGroup = 0;

        double groupWithCar = 0.00;
        double groupWithMircobus = 0.00;
        double groupWithSmallBus = 0.00;
        double groupWithBus = 0.00;
        double groupWithTrain = 0.00;



        for (int i = 0; i < countOfGroup; i++)
        {
            int numberOfGroup = int.Parse(Console.ReadLine());

            totalSumOfGroup += numberOfGroup;

            if (numberOfGroup <= 5) groupWithCar += numberOfGroup;
            else if (numberOfGroup <= 12) groupWithMircobus += numberOfGroup;
            else if (numberOfGroup <= 25) groupWithSmallBus += numberOfGroup;
            else if (numberOfGroup <= 40) groupWithBus += numberOfGroup;
            else
            {
                groupWithTrain += numberOfGroup;
            }
        }

        double percentWithCar = groupWithCar * 100 /  totalSumOfGroup;
        double percentWithMicrobus = groupWithMircobus * 100 / totalSumOfGroup;
        double percentWithSmallBus = groupWithSmallBus / totalSumOfGroup * 100;
        double percentWithBus = groupWithBus / totalSumOfGroup * 100;
        double percentWithTrain = groupWithTrain / totalSumOfGroup * 100;
       
        Console.WriteLine("{0:F2}%", percentWithCar);
        Console.WriteLine("{0:F2}%", percentWithMicrobus);
        Console.WriteLine("{0:F2}%", percentWithSmallBus);
        Console.WriteLine("{0:F2}%", percentWithBus);
        Console.WriteLine("{0:F2}%", percentWithTrain);

    }
}
