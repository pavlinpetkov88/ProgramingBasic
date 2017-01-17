using System;

class Fox
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("*\\" + new string('-', 2 * n - 1) + "/*");

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('*', 2 + i) + "\\"
                            + new string('-', 2 * n - 3 - i * 2) + "/"
                            + new string('*', 2 + i));
        }
        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine("|" + new string('*', n / 2 + i) + "\\" +
                            new string('*', n - i * 2) + "/" +
                            new string('*', n / 2 + i) + "|");
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('-', i + 1) + "\\" +
                            new string('*', 2 * n - 1 - i * 2) + "/" +
                            new string('-', i + 1));
        }

    }
}
