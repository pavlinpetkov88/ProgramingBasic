using System;

class Exam4
{
    static void Main()
    {

        int numberOfStudent = int.Parse(Console.ReadLine());

        double over5 = 0;
        double scoreBetween4and5 = 0;
        double scoreBetween3and4 = 0;
        double under3 = 0;

        double midScore = 0;

        for (int i = 0; i < numberOfStudent; i++)
        {
            double score = double.Parse(Console.ReadLine());

            midScore += score;

            if (score >= 5)
            {
                over5++;
            }
            else if (score >= 4)
            {
                scoreBetween4and5++;
            }
            else if (score >= 3)
            {
                scoreBetween3and4++;
            }
            else
            {
                under3++;
            }
        }

        var pecentOver5 = over5 * 100 / numberOfStudent;
        var percentBetween4and5 = scoreBetween4and5 * 100 / numberOfStudent;
        var pecentBetween3and4 = scoreBetween3and4 * 100 / numberOfStudent;
        var percentUnder3 = under3 * 100 / numberOfStudent;


        Console.WriteLine("Top students: {0:f2}%", pecentOver5);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", percentBetween4and5);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", pecentBetween3and4);
        Console.WriteLine("Fail: {0:f2}%", percentUnder3);
        Console.WriteLine("Average: {0:f2}", midScore / numberOfStudent);

    }
}
