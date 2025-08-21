using System;

class ArraySum
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];
        int sum = 0;

        // Input elements
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];  // add to sum directly
        }

        Console.WriteLine("Sum of array elements = " + sum);
        Console.ReadLine();
    }
}
