using System;

class MaxNumber
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue;

        for (int i = 0 ; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < minNumber)
            {
                minNumber = num;
            }
        }
        Console.WriteLine(minNumber);
    }
}

