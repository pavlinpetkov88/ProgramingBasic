using System;

class FlowerShop
{
    static void Main()
    {

        int mongoliaPcs = int.Parse(Console.ReadLine());
        int hyacinthPcs = int.Parse(Console.ReadLine());
        int rosePcs = int.Parse(Console.ReadLine());
        int cactusPcs = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double mongolia = 3.25 * mongoliaPcs;
        double hyacinth = 4.00 * hyacinthPcs;
        double rose = 3.50 * rosePcs;
        double cactus = 8.00 * cactusPcs;

        double totalSum = mongolia + hyacinth + rose + cactus;
        double percent = Math.Abs(totalSum - totalSum * 0.05);

        if (giftPrice > percent)
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - percent));
        }
        else
        {
            Console.WriteLine("She is left with {0} leva.", Math.Truncate(percent - giftPrice));
        }

    }
}
