using System;

class CurrencyNotes
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] count = new int[notes.Length];

        int remaining = amount;

        for (int i = 0; i < notes.Length; i++)
        {
            if (remaining >= notes[i])
            {
                count[i] = remaining / notes[i];
                remaining = remaining % notes[i];
            }
        }

        Console.WriteLine("Minimum notes required for Rs." + amount + ":");
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine("Notes of Rs.{0} = {1}", notes[i], count[i]);
        }

        Console.ReadLine();
    }
}
