using System;
class TUT_1_14
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        string[] words = { "Zero", "One", "Two", "Three", "Four",
 "Five", "Six", "Seven", "Eight", "Nine" };
        Console.Write("OUTPUT: ");
        foreach (char c in input)
        {
            if (char.IsDigit(c))
                Console.Write(words[c - '0'] + " ");
            else
            {
                Console.WriteLine("\nInvalid input.");
                return;
            }
        }
    }
}