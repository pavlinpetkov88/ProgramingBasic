using System;


class Firm
{
    static void Main()
    {
        int hourNeed = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        var training = (days - (days / 10m)) * 8;
        var overWork = workers * (2 * days);
        var allWorkHours = Math.Floor(training + overWork);
        var prinTimeLeft = allWorkHours - hourNeed;

        if (hourNeed <= allWorkHours)
        {
            Console.WriteLine("Yes!{0:f0} hours left.", prinTimeLeft);
        }
        else
        {
            Console.WriteLine("Not enough time!{0:f0} hours needed.", hourNeed - allWorkHours);
        }
    }
}
