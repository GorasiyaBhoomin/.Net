using System;

class ArraySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];

        // Input elements
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        int X = Convert.ToInt32(Console.ReadLine());

        // Search
        int found = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] == X)
            {
                found = 1;
                break;
            }
        }

        Console.WriteLine(found);
        Console.ReadLine();
    }
}
