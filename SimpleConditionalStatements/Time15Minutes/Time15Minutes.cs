using System;

class Time15Minutes
{
    static void Main()
    {
       
        double hours = double.Parse(Console.ReadLine());
        double minutes = double.Parse(Console.ReadLine());
        
        double hoursToMinutes = (hours * 60) + minutes;
        double total = hoursToMinutes +15;

        var time = TimeSpan.FromMinutes(total);
        Console.WriteLine(string.Format("{0}:{1:00}", time.Hours, time.Minutes));
               
    }
}

