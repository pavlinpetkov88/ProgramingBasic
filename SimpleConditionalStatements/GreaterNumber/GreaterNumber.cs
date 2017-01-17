using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two integers");
        var firstnumber = int.Parse(Console.ReadLine());
        var secoundnumber = int.Parse(Console.ReadLine());
        if (firstnumber > secoundnumber)
        {
            Console.WriteLine("Greater number: {0}", firstnumber);
        }
        else
        {
            Console.WriteLine("Greater number: {0}", secoundnumber);
        }
    }
}
