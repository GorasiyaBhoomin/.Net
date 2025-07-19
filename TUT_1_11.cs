using System;

class TUT_1_11
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Gender (M/F): ");
        char gender = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        if (gender == 'M')
        {
            Console.WriteLine("Mr. " + name);
        }
        else if (gender == 'F')
        {
            Console.WriteLine("Ms. " + name);
        }
        else
        {
            Console.WriteLine("Invalid gender input. Please enter M or F.");
        }
    }
}
