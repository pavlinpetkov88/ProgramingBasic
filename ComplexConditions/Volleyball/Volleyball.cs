using System;

class Volleyball
{
    static void Main()
    {

        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        if (year == "leap")
        {
            double play = 48 - h;
            double playInSofia = play * (3.0 / 4);
            double weekends = p * (2.0 / 3);
            double leapYear = playInSofia + h + weekends;
            double total = Math.Truncate(leapYear + ((leapYear * 15) / 100));
            Console.WriteLine(total);
        }

        else if (year == "normal")
        {
            double play = 48 - h;
            double playInSofia = play * (3.0 / 4);
            double weekends = p * (2.0 / 3);
            double normalYear = Math.Truncate(playInSofia + h + weekends);
            
            Console.WriteLine(normalYear);
        }
    }
}
