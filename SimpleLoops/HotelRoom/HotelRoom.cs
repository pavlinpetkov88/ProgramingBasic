using System;

class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int numbersOfNight = int.Parse(Console.ReadLine());

        double apartment = 0.0;
        double studio = 0.0;

        if (month == "may" || month == "october") 
        {
            if (numbersOfNight <= 7) studio = 50;
            else if (numbersOfNight > 7 && numbersOfNight <= 14) studio = 50 - (50 * 5) / 100.00;
            else if (numbersOfNight > 14) studio = 50 - (50 * 30) / 100.00;
            if (numbersOfNight <= 14) apartment = 65;
            else if (numbersOfNight > 14) apartment = 65 - (65 * 10) / 100.00;
        }
        else if (month == "june" || month == "september") 
        {
            if (numbersOfNight <= 14) studio = 75.20;
            else if (numbersOfNight > 14) studio = 75.20 - (75.20 * 20) / 100.00;
            if (numbersOfNight <= 14) apartment = 68.70;
            else if (numbersOfNight > 14) apartment = 68.70 - (68.70 * 10) / 100.00;
        }
        else if (month == "july" || month == "august")
        {
            studio = 76;
            if (numbersOfNight <=14) apartment = 77;
            else if (numbersOfNight > 14) apartment = 77 - (77 * 10) / 100.00;
        }
        
        Console.WriteLine("Apartment: {0:f2} lv.", apartment * numbersOfNight);
        Console.WriteLine("Studio: {0:f2} lv.", studio * numbersOfNight);
    }
}