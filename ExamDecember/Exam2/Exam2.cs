using System;

class Exam2
{
    static void Main()
    {
        double subraniPari = double.Parse(Console.ReadLine());
        double shirochinaNaPoda = double.Parse(Console.ReadLine());
        double dyljinanaPoda = double.Parse(Console.ReadLine());
        double strananaTR = double.Parse(Console.ReadLine());
        double visochinaTR = double.Parse(Console.ReadLine());
        double cenaNaPlochka = double.Parse(Console.ReadLine());
        double sumaMaistor = double.Parse(Console.ReadLine());

        var pod = shirochinaNaPoda * dyljinanaPoda;
        var plochka = strananaTR * visochinaTR / 2;
        var nujnuplochki = Math.Ceiling( pod / plochka) + 5;
        var maistor = (nujnuplochki * cenaNaPlochka) + sumaMaistor;

        if (subraniPari >= maistor)
        {
            Console.WriteLine("{0:f2} lv left.", subraniPari - maistor);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(maistor - subraniPari));
        }
    }
}
