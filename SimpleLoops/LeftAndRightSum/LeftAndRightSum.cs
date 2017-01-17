using System;

class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firsthaft = 0;
        int secoundhaft = 0;

        for (int i = 0; i < 2 * n ; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i < n )
            {
                firsthaft += number;
                
            }
            else 
            {
                secoundhaft += number;
            }
        }
        if (firsthaft == secoundhaft)
        {
            Console.WriteLine("Yes , sum = {0}", firsthaft);
        }
        else 
        {
            Console.WriteLine("No, diff = " + Math.Abs(firsthaft - secoundhaft));
        }
    }
}

