using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.Write("*");
            if (i == (n - 1)/ 2 - 1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.Write("*");
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

    }
}



//Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" +
//                              new string(' ', n) + 
//                              "*" + new string('/', 2 * n - 2) + "*" );
            