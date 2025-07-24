using System;
namespace ConsoleApp2
{
    internal class TUT_1_19
    {
        static void Main(string[] args)
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}