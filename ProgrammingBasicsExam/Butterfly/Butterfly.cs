using System;
public class Exercise76
{
    public static void Main()
    {
        int row, column;

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (column == 3 || (row == 0 && column > 0 && column < 6))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}