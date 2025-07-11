using System; // Importing System namespace to use built-in functions like Console

namespace ConsoleApplication1 // Declaring a namespace
{
    class TUT_1_5// Declaring a class named Program
    {
        static void Main(string[] args) // Main method: entry point of the program
        {
            int n, fact = 1; // Declare an integer 'n' for input, and initialize 'fact' to 1

            Console.WriteLine("Enter Number : "); // Prompt user to enter a number

            string str = Console.ReadLine(); // Read user input as a string

            n = Convert.ToInt32(str); // Convert the string input to integer and store in 'n'

            for (int i = 1; i <= n; i++) // Loop from 1 to n
            {
                fact = fact * i; // Multiply 'fact' by 'i' in each iteration (calculating factorial)
            }

            Console.WriteLine("Factorial : {0}", fact); // Print the factorial result using formatted output

            Console.Read(); // Pause the console window until a key is pressed
        }
    }
}
