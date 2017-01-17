using System;

class RhombusOfStars
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int k = 1; k < row; k++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
        for (int row = 1; row < n; row++)
        {
            Console.Write(new string(' ', row));
            Console.Write("*");
            for (int k = 1; k < n - row; k++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
        
    }
}
