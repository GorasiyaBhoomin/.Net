using System;
namespace ConsoleApp2
{
    internal class TUT_1_20
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
