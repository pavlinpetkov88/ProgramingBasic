using System;

class PointOnRectangleBorder
{
    static void Main()
    {

        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x == x1 && y >= y1 && y2 >= y || x == x2 && y >= y1 && y2 >= y)
        {
            Console.WriteLine("Border");
            
        }
        else if (y1 == y && x1 <= x && x2 >= x || y2 == y && x1 <= x && x2 >= x)
        {
            Console.WriteLine("Border");
        }
        
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
