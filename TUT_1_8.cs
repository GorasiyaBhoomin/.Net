using System;

namespace NameToUpper
{
    class TUT_1_8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); 

            string upperName = name.ToUpper();

            Console.WriteLine("Output: " + upperName); 

            Console.ReadLine();
        }
    }
}
