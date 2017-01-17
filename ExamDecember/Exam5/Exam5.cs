using System;

class Exam5
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', 2 * n - 1) + "/" + "|" + "\\" + new string('.', 2 * n - 1));
        Console.WriteLine(new string('.', 2 * n - 1) + "\\" + "|" + "/" + new string('.', 2 * n - 1));

        for (int i = 0; i <= 2 * n - 1; i++)
        {
            Console.WriteLine(new string('.', 2 * n - 1 - i) + "*" + new string('-', i ) + "*" 
                                            + new string('-', i) + "*" + new string('.', 2 * n - 1 - i));
        }

        Console.WriteLine(new string('*', 4 * n + 1));

        for (int i = 0; i < 2 * n ; i++)
        {
            Console.Write("*");
            Console.Write(".");
        }
        Console.WriteLine("*");
        
        Console.WriteLine(new string('*', 4 * n + 1));
    }
}
