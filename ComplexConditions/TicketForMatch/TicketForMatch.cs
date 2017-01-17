using System;

class TicketForMatch
{
    static void Main()
    {

        double budget = double.Parse(Console.ReadLine());
        string categori = Console.ReadLine().ToLower();
        int numberOfPeople = int.Parse(Console.ReadLine());

        double budgetPerPeople = 0;
        double normalOrVip = 0;

        if (categori == "normal")
        {
            normalOrVip = 249.99;
        }
        else
        {
            normalOrVip = 499.99;
        }

        if (numberOfPeople >= 1 && numberOfPeople <= 4) budgetPerPeople = 0.75;
        else if (numberOfPeople >= 5 && numberOfPeople <= 9) budgetPerPeople = 0.6;
        else if (numberOfPeople >= 10 && numberOfPeople <= 24) budgetPerPeople = 0.5;
        else if (numberOfPeople >= 25 && numberOfPeople <= 49) budgetPerPeople = 0.4;
        else
        {
            budgetPerPeople = 0.25;
        }

        double totalSum = normalOrVip * numberOfPeople;
        double budgetSum = budget - (budgetPerPeople * budget);

        if (totalSum < budgetSum)
        {
            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(budgetSum - totalSum));
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(totalSum - budgetSum));
        }
    }
}

