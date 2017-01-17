using System;

class Sequence2kPlus1
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int num = 1, i = 1; i <= n; i += num, num = num * 2 + 1)
        {
            Console.WriteLine(num);
        }
    }
    
}
