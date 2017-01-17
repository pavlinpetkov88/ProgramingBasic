using System;

class EvenPowersOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int num = 1, i = 1; i <= n / 2 + 1; i++, num *= 4)
        {

            Console.WriteLine(num);
        }
    }
}
