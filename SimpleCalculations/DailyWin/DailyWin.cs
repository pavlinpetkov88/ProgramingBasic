using System;

class DailyWin
{
    static void Main()
    {
        int workDayPerMonth = int.Parse(Console.ReadLine());
        decimal moneyPerDay = decimal.Parse(Console.ReadLine());
        decimal usd = decimal.Parse(Console.ReadLine());

        var monthPayment = workDayPerMonth * moneyPerDay;
        var yearlyInCome = (monthPayment * 12) + (monthPayment * 2.5m);
        var duty = (yearlyInCome * 25) / 100;
        var cleanYearlyInCome = (yearlyInCome - duty) * usd;
        var averagePyamentPerDay = cleanYearlyInCome / 365;

        Console.WriteLine("{0:f2}", averagePyamentPerDay);

    }
}
