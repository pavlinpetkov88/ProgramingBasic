using System;

class Trip
{
    static void Main()
    {

        double number = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if (number <= 100)
        {
            if (season == "summer")
            {
                number = (number * 30) / 100;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", number);
            }
            else if (season == "winter")
            {
                number = (number * 70) / 100;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}", number);
            }
        }
        else if (number > 100 && number <= 1000)
        {
            if (season == "summer")
            {
                number = (number * 40) / 100;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", number);
            }
            else if (season == "winter")
            {
                number = (number * 80) / 100;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", number);
            }
        }
        else if (number >1000 && number <= 5000)
        {
            number = (number * 90) / 100;
            Console.WriteLine("Somewhere in Europe");
            Console.WriteLine("Hotel - {0:f2}", number);
        }
    }
}

