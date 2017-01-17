using System;

class bonusScoreScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double bonusScore = 0.0;

        if (number <= 100)
        {
            bonusScore = 5;
        }
        else if (number <= 1000)
        {
            bonusScore = 0.2 * number;
        }
        else
        {
            bonusScore = 0.1 * number;
        }
        if (number % 2 == 0)
        {
            bonusScore += 1;
        }

        if (number % 10 == 5)
        {
            bonusScore += 2;
        }

        Console.WriteLine(bonusScore);
        Console.WriteLine(bonusScore + number);


    }
}
