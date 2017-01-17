using System;

class RepairOfTile
{
    static void Main()
    {
        int lenghtside = int.Parse(Console.ReadLine());
        double widthOfTile = double.Parse(Console.ReadLine());
        double lenghtOfTile = double.Parse(Console.ReadLine());
        int widthOfBench = int.Parse(Console.ReadLine());
        int lenghtOfBench = int.Parse(Console.ReadLine());

        var totalspace = lenghtside * lenghtside;
        var usedPlaceOfTile = widthOfTile * lenghtOfTile;
        var usedPlaceBench = widthOfBench * lenghtOfBench;
        var countOfUserTiles = (totalspace - usedPlaceBench) / usedPlaceOfTile;
        Console.WriteLine(countOfUserTiles);
        Console.WriteLine(countOfUserTiles * 0.2);
    }
}