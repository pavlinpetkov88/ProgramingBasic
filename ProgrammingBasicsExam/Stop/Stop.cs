using System;

class Stop
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', n - i) + "//" + new string('_', 2 * n - 1 + i * 2) + "\\\\" + new string('.', n - i));
        }
        for (int i = 0; i < n - n + 1; i++)
        {
            Console.WriteLine("//" + new string('_', n * 2 - 3) + "STOP!" + new string('_', n * 2 - 3) + "\\\\");
        }
        Console.WriteLine("\\\\" + new string('_', 4 * n  - 1) + "//");
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', n - n + 1 + i) + "\\\\" + new string('_', 4 * n - 3 - i * 2) + "//" + new string('.', n - n + 1 + i));
        }
    }
}
