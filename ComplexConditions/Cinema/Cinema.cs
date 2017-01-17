using System;

class Cinema
{
    static void Main()
    {

        string typeOfCinema = Console.ReadLine();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double ticketPrice = 0;

        if (typeOfCinema == "Premiere")
        {
            ticketPrice = 12.00;
        }
        else if (typeOfCinema == "Normal")
        {
            ticketPrice = 7.50;
        }
        else if (typeOfCinema == "Discount")
        {
            ticketPrice = 5.00;
        }

        double result = (r * c) * ticketPrice;
        Console.WriteLine("{0:f2}", result + " leva");
    }
}
