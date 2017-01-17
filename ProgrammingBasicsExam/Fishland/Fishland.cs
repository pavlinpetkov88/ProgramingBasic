using System;

class Fishland
{
    static void Main()
    {

        double pricePerKilogramsMackerel = double.Parse(Console.ReadLine());
        double pricePerKilogramsSpart = double.Parse(Console.ReadLine());
        double pricePerKilogramsBeltedBonito = double.Parse(Console.ReadLine());
        double pricePerKilogramsScad = double.Parse(Console.ReadLine());
        double pricePerKilogramsClams = double.Parse(Console.ReadLine());

        double priceBeltedBonito = pricePerKilogramsMackerel + pricePerKilogramsMackerel * 0.60;
        double priceScad = pricePerKilogramsSpart + pricePerKilogramsSpart * 0.80;

        double BeltedBonito = pricePerKilogramsBeltedBonito * priceBeltedBonito;
        double Scad = pricePerKilogramsScad * priceScad;
        double Clams = pricePerKilogramsClams * 7.5;

        double result = BeltedBonito + Scad + Clams;
        
        Console.WriteLine("{0:f2}", result);
    }
}
