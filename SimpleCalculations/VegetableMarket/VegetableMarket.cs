using System;

class VegetableMarket
{
    static void Main()
    {
        var vegetableprice = double.Parse(Console.ReadLine());
        var fruitprice = double.Parse(Console.ReadLine());
        int vegetablkilo = int.Parse(Console.ReadLine());
        int fruitkilo = int.Parse(Console.ReadLine());

        var priceofvegetables = vegetableprice * vegetablkilo;
        var priceofFruit = fruitprice * fruitkilo;
        Console.WriteLine((priceofvegetables + priceofFruit) / 1.94);
    }
}
