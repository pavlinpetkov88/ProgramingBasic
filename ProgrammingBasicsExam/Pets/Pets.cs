using System;

class Pets
{
    static void Main()
    {

        int days = int.Parse(Console.ReadLine());
        int leftFood = int.Parse(Console.ReadLine());
        double foodForDog = double.Parse(Console.ReadLine());
        double foodForCat = double.Parse(Console.ReadLine());
        double foodForTurtle = double.Parse(Console.ReadLine());

        var dog = days * foodForDog;
        var cat = days * foodForCat;
        var turtle = days * (foodForTurtle / 1000);

        var foodSum = dog + cat + turtle;

        if (leftFood >= foodSum)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Truncate(leftFood - foodSum));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodSum - leftFood));
        }


    }
}
