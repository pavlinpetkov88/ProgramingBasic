using System;

class Fibonacci
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int f0 = 1;
        int f1 = 1;
        int sum = 0;

        if (n < 2)
        {
            Console.WriteLine('1');
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {

                sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            Console.WriteLine(sum);
        }

    }
}
