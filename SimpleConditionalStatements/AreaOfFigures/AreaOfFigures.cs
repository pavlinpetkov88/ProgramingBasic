using System;

class AreaOfFigures
{
    static void Main()
    {

        string nameOfFigure = Console.ReadLine();

        if (nameOfFigure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(side * side);
        }
        else if (nameOfFigure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
        else if (nameOfFigure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine("{0:f3}", area);
        }
        else if (nameOfFigure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine((a * b) / 2);
        }

    }
}
