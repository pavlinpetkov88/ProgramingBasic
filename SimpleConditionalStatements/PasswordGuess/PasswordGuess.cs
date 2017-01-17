using System;
class PasswordGuess
{
    static void Main()
    {
        var pass = Console.ReadLine();

        while (true)
        {
            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
                break;
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
            pass = Console.ReadLine();


        }
        
    }
}
