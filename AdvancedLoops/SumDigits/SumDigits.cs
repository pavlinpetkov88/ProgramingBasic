using System;

class SumDigits
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        int diff = num;
        
        do
        {
            sum += diff % 10;
            diff /= 10;
        } while (diff != 0);

        Console.WriteLine(sum);
    }
}
