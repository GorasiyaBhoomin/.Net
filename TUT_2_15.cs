using System;

class PrintName
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();   // Accept name from user

        Console.WriteLine("You entered: " + name);  // Print the name

        Console.ReadLine();
    }
}
