using System;

class Logistics
{
    static void Main()
    {

        int numberOfCargo = int.Parse(Console.ReadLine());

        double totalKgOfCargo = 0.00;
        double bus = 0.00;
        double hvg = 0.00;
        double train = 0.00;

        for (int i = 0; i < numberOfCargo; i++)
        {
            int kgOfCardgo = int.Parse(Console.ReadLine());

            totalKgOfCargo += kgOfCardgo;

            if (kgOfCardgo <= 3) bus += kgOfCardgo;
            else if (kgOfCardgo <= 11) hvg += kgOfCardgo;
            else
            {
                train += kgOfCardgo;
            }
        }
        
        double perTon = (bus * 200 + hvg * 175 + train * 120) / totalKgOfCargo;

        double withBus = (bus / totalKgOfCargo) * 100;
        double withHVG = (hvg / totalKgOfCargo) * 100;
        double withTrain = (train / totalKgOfCargo) * 100;

        Console.WriteLine("{0:f2}", perTon);

        Console.WriteLine("{0:f2}%", withBus);
        Console.WriteLine("{0:f2}%", withHVG);
        Console.WriteLine("{0:f2}%", withTrain);
    }

}
    
