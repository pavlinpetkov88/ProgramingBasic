using System;
using System.Numerics;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var number = 1;

        while (number <= n)
        {
            Console.WriteLine(number);
            number = number* 2 + 1;
            
        }
        
    }
}

