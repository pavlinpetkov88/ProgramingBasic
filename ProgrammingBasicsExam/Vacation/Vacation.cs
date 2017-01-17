using System;

    class Vacation
    {
        static void Main()
        {

        int numOfOldPeoples = int.Parse(Console.ReadLine());
        int numbOfStudent = int.Parse(Console.ReadLine());
        int numOfNight = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        
        double costTransport = 0;

     
            if (transport == "train" && numbOfStudent + numOfOldPeoples < 50)
            costTransport = ((24.99 * numOfOldPeoples) + (numbOfStudent * 14.99)) * 2;
            else if (transport == "bus")
            costTransport = ((32.50 * numOfOldPeoples) + (numbOfStudent * 28.50)) * 2;
            else if (transport == "boat")
            costTransport = ((42.99 * numOfOldPeoples) + (numbOfStudent * 39.99)) * 2;
            else if (transport == "airplane")
            costTransport = ((70.00 * numOfOldPeoples) + (numbOfStudent * 50.00)) * 2;
            else if (transport == "train" )
            costTransport = (((24.99 * 0.50) * numOfOldPeoples) + (numbOfStudent * (14.99 * 0.50))) * 2;
        


        var hotelNight = numOfNight * 82.99;
        var comision = (hotelNight + costTransport) * 0.10;
        var totalsum = hotelNight + costTransport + comision;

        Console.WriteLine("{0:F2}", totalsum);


        }
    }
