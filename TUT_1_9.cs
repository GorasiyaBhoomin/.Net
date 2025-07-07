using System;

namespace ToggleCaseApp
{
    class TUT_1_9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine(); 

            string toggleCase = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    toggleCase += char.ToLower(ch);
                else if (char.IsLower(ch))
                    toggleCase += char.ToUpper(ch);
                else
                    toggleCase += ch;
            }

            Console.WriteLine("Output: " + toggleCase); 

            Console.ReadLine();
        }
    }
}
