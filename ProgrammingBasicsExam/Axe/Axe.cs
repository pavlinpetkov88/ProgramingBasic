using System;

    class Axe
    {
        static void Main()
        {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', n * 3) + "*" + "*" + new string('-', n * 2 - 2));

        int underAxe = 0;
        int midSide = 0;
        int lastSide = 0;

        if (n % 2 == 1)
        {
            underAxe = 5 * n / 2 + 2;
            midSide = n * 2 - 2;
            lastSide = n / 2 + 1;
        }
        else
        {
            underAxe = 5 * n / 2 + 1;
            midSide = n * 2  - 1;
            lastSide = n / 2;
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', i + 1) + "*" + new string('-', n * 2 - 3 - i));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('*', 3 * n + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(new string('-', n * 3 - i) + "*" + new string('-', n - 1 + i * 2) + "*" + new string('-', n - 1 - i));
        }
        Console.WriteLine(new string('-', underAxe) + new string('*', midSide) + new string('-', lastSide));

        }
    }
