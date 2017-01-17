using System;

class NumbersFromNTo1
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        for (int i = number; 1 <= i; i--)
        {
            Console.WriteLine(i);
        }
    }
}
