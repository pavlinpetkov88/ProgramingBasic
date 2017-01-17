using System;

class Hospital
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int numberOfDoctor = 7;

        for (int i = 1; i <= n; i++)
        {
            int pacientPerDay = int.Parse(Console.ReadLine());

            if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                numberOfDoctor++;
            }
            if (pacientPerDay > numberOfDoctor)
            {
                treatedPatients += numberOfDoctor;
                untreatedPatients += pacientPerDay - numberOfDoctor;
            }
            else
            {
                treatedPatients += pacientPerDay;
            }
        }

        
        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}
