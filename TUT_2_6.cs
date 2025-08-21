using System;

public class Hello3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("You entered the following {0} command line arguments:",
           args.Length);

        for (int i = 0; i < args.Length; i++)   
        {
            Console.WriteLine(args[i]);         // Missing statement-2
        }                                       // Missing statement-3
                                                // Missing statement-4
    }c
}
