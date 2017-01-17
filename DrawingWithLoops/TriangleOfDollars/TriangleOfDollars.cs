using System;

class TriangleOfDollars
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write('$');

            for (int k = 1; k < i; k++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }

    }
}

