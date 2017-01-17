using System;

class Exam6
{
    static void Main()
    {
        var firstCh = char.Parse(Console.ReadLine());
        var secondCh = char.Parse(Console.ReadLine());
        var thridCh = char.Parse(Console.ReadLine());

        int count = 0;

        for (char i = firstCh; i <= secondCh; i++)
        {
            for (char k = firstCh; k <= secondCh; k++)
            {
                for (char j = firstCh; j <= secondCh; j++)
                {
                    if (i != thridCh && k != thridCh && j != thridCh)
                    {
                        Console.Write("{0}{1}{2} ", i, k, j);
                        count++;
                    }
                    
                }
            }
        }

        Console.WriteLine(count);
    }
}
