﻿using System;
namespace ConsoleApp2
{
    internal class TUT_1_22
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {

                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}