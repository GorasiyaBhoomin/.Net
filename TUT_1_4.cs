﻿using System;

namespace ConsoleApplication1
{
    class TUT_1_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string str = Console.ReadLine();
            int x = Convert.ToInt32(str);

            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");

            Console.Read();
        }
    }
}
