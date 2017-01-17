using System;

class SquareFrame
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.Write('+');
        for (var i = 0; i < n - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('|');
            for (var j = 0; j < n - 2; j++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" |");

        }

        Console.Write('+');
        for (var i = 0; i < n - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");

    }
}