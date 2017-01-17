using System;

class totalMinutesSecond
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int thried = int.Parse(Console.ReadLine());

        var totalMinutes = first + secound + thried;
     
        if (totalMinutes >= 0 & totalMinutes <= 59)
        {
            Console.WriteLine("0:{0:00}", totalMinutes);
        }

        if (totalMinutes >= 60 & totalMinutes <= 119)
        {
            Console.WriteLine("1:{0:00}", totalMinutes % 60);
        }

        if (totalMinutes >= 120 & totalMinutes <= 179)
        {
            Console.WriteLine("2:{0:00}", totalMinutes % 120);
        }
      
    }
}
