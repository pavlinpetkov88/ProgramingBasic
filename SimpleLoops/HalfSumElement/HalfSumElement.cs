using System;

class HalfSumElement
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int maxNumber = int.MinValue;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
            if (num > maxNumber)
            {
                maxNumber = num;
                
              
            }
        }
        int totalSum = sum - maxNumber;
        if (totalSum == maxNumber)
        {
            Console.WriteLine("Yes sum = {0}", maxNumber);
        }
        else
        {
            Console.WriteLine("No Diff {0}", + Math.Abs(sum - maxNumber - maxNumber));
        }
    }
}

