using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("*");
        }

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int k = 1; k < row; k++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }
        for (int row = 1; row < n; row++)
        {
            Console.Write(new string(' ', row));
            Console.Write("*");
            for (int k = 1; k < n - row; k++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }

    }
}

