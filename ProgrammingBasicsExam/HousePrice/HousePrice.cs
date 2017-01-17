using System;

class HousePrice
{
    static void Main()
    {

        double smallRoom = double.Parse(Console.ReadLine());
        double kitchen = double.Parse(Console.ReadLine());
        double meterPrice = double.Parse(Console.ReadLine());

        double sizeOfSecoundRoom = (smallRoom / 10) + smallRoom;

        double sizeOfTriedRoom = (sizeOfSecoundRoom / 10) + sizeOfSecoundRoom;
        double bathRoom = smallRoom / 2;

        double totalArea = smallRoom + kitchen + sizeOfSecoundRoom + sizeOfTriedRoom + bathRoom;
        double percent = (totalArea * 0.05) + totalArea;

        double sum = percent * meterPrice;

        Console.WriteLine("{0:f2}", sum);

    }
}
