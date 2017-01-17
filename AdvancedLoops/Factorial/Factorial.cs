using System;

class Factorial
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int sum = 1;

        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
}
