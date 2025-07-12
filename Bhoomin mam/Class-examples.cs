using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            double temp = 32.95;
            char gender = 'm'; // Fixed: char uses single quotes
            string name = "RKU";
            int no = 123; // Added a declaration for 'no'

            Console.WriteLine(name); // Fixed: WriteLine with capital L
            Console.WriteLine("Gender is: " + gender);
            Console.WriteLine("Number is: " + no);
            Console.WriteLine("Temperature is: " + temp);
        }
    }
}
