using System;

class Rocket
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine(new string('.', (3 * n - 2) / 2 - i) + "/" + new string(' ', i * 2) + "\\" + new string('.', (3 * n - 2) / 2 - i));
        }

        Console.WriteLine(new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2));

        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine(new string('.', n / 2) + "|" + new string('\\', 2 * n - 2) + "|" + new string('.', n / 2));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', n / 2 - i) + "/" + new string('*', 2 * n - 2 + i * 2) + "\\" + new string('.', n / 2 - i));
        }
    }
}