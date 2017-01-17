using System;

class SmartLily
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washMachine = double.Parse(Console.ReadLine());
        int priceOfToy = int.Parse(Console.ReadLine());

        int evenBDay = 0;
        int oddBDay = 0;
        int moneyPerEvenBDay = 0;
        int saveMoneyFromToy = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                evenBDay++;
                for (int j = 0; j < evenBDay; j++)
                {
                    moneyPerEvenBDay = moneyPerEvenBDay + 10;
                }
            }
            else 
            {
                oddBDay++;
                saveMoneyFromToy += priceOfToy;
            }
            
        }

        int totalsum = moneyPerEvenBDay + saveMoneyFromToy - evenBDay;
        if (totalsum >= washMachine)
        {
            Console.WriteLine("Yes! {0:f2}", Math.Abs(totalsum - washMachine));
        }
        else
        {
            Console.WriteLine("No! {0:f2}", Math.Abs(totalsum - washMachine));
        }
    }
}
