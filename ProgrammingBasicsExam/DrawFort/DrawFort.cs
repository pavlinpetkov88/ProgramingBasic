using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int underLine = n - 4;

        if (n % 2 == 1)
        {
            underLine = n - 3;
        }

        Console.WriteLine("/" + new string('^', n / 2)
            + "\\" + new string('_', underLine) + "/"
            + new string('^', n / 2) + "\\");

        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
        }

        Console.WriteLine("|" + new string(' ', n / 2 + 1)
                     + new string('_', underLine)
                     + new string(' ', n / 2 + 1) + "|");

        Console.WriteLine("\\"
            + new string('_', n / 2)
            + "/" + new string(' ', underLine)
            + "\\" + new string('_', n / 2) + "/");
    }
}