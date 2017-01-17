using System;

class maxNumber
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int maxNumber = int.MinValue;
        
        for (int i = 0 ; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }
        Console.WriteLine(maxNumber);
    }
}

