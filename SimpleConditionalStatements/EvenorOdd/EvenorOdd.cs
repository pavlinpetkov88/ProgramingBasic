using System;


class EvenorOdd
{
    static void Main(string[] args)
    {
        var numb = double.Parse(Console.ReadLine());
        var even = (numb % 2 == 0);
        if ( even )
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}

