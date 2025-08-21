


using System;

namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter first number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operators ---");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {(float)A / B}"); // type casting
            Console.WriteLine($"A % B = {A % B}");

            // Relational Operators
            Console.WriteLine("\n--- Relational Operators ---");
            Console.WriteLine($"A == B : {A == B}");
            Console.WriteLine($"A != B : {A != B}");
            Console.WriteLine($"A > B : {A > B}");
            Console.WriteLine($"A < B : {A < B}");
            Console.WriteLine($"A >= B : {A >= B}");
            Console.WriteLine($"A <= B : {A <= B}");

            // Logical Operators (using bool)
            bool condition1 = (A > 0);
            bool condition2 = (B > 0);

            Console.WriteLine("\n--- Logical Operators ---");
            Console.WriteLine($"condition1 && condition2 : {condition1 && condition2}");
            Console.WriteLine($"condition1 || condition2 : {condition1 || condition2}");
            Console.WriteLine($"!condition1 : {!condition1}");

            // Bitwise Operators
            Console.WriteLine("\n--- Bitwise Operators ---");
            Console.WriteLine($"A & B = {A & B}");
            Console.WriteLine($"A | B = {A | B}");
            Console.WriteLine($"A ^ B = {A ^ B}");
            Console.WriteLine($"~A = {~A}");
            Console.WriteLine($"A << 1 = {A << 1}");
            Console.WriteLine($"A >> 1 = {A >> 1}");

            // Assignment Operators
            Console.WriteLine("\n--- Assignment Operators ---");
            int C = A;
            C += B;
            Console.WriteLine($"C += B : {C}");
            C -= B;
            Console.WriteLine($"C -= B : {C}");
            C *= B;
            Console.WriteLine($"C *= B : {C}");
            C /= (B == 0 ? 1 : B);  // avoid divide by zero
            Console.WriteLine($"C /= B : {C}");

            // Unary Operators
            Console.WriteLine("\n--- Unary Operators ---");
            int X = A;
            Console.WriteLine($"++X = {++X}"); // pre-increment
            Console.WriteLine($"--X = {--X}"); // pre-decrement

            // Different Data Types
            Console.WriteLine("\n--- Different Data Types ---");
            double d = (double)A / B;
            decimal dec = (decimal)A / B;
            char ch = 'C';
            string str = "Hello C#";

            Console.WriteLine($"Double value (A/B): {d}");
            Console.WriteLine($"Decimal value (A/B): {dec}")csc;
            Console.WriteLine($"Character value: {ch}");
            Console.WriteLine($"String value: {str}");

            Console.ReadLine();
        }
    }
}

