﻿using System;

class ConcatenateData
{
    static void Main(string[] args)
    {
        var fistname = Console.ReadLine();
        var lastname = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var town = Console.ReadLine();

        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", fistname, lastname, age, town);
    }
}