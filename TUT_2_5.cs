using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];   // declare array
            int sum = 0;              // initialize sum

            // Input loop
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            // Sum loop
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }
    }
}

