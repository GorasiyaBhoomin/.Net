using System;

namespace NameToUpper
{
    class TUT_1_8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Input: John F Kennedy

            string upperName = name.ToUpper(); // Convert to uppercase

            Console.WriteLine("Output: " + upperName); // Output: JOHN F KENNEDY

            Console.ReadLine(); // Pause the program
        }
    }
}
