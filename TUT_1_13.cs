using System;
class TUT_1_13
{
    static void Main()
    {
        int n = 11; // Number of terms to print
        int a = 0, b = 1, c;
        Console.Write("Fibonacci Series: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}