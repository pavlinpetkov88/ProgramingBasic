using System;

class ExcellentOrNot
{
    static void Main(string[] args)
    {
        var grage = double.Parse(Console.ReadLine());
        if (grage >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}