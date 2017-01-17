using System;

class PowersOfTwo
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 1, num = 0; num <= n; i *= 2, num++)
        {

            Console.WriteLine(i);
        }

    }
}
