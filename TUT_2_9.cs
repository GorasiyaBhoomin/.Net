using System;

class DistinctNumbers
{
    public static void FindTwoNumbers(int[] arr)
    {
        int xorAll = 0;

        // Step 1: XOR of all elements
        foreach (int num in arr)
            xorAll ^= num;

        // Step 2: Get rightmost set bit
        int setBit = xorAll & -xorAll;

        int num1 = 0, num2 = 0;

        // Step 3: Divide into two groups
        foreach (int num in arr)
        {
            if ((num & setBit) != 0)
                num1 ^= num;
            else
                num2 ^= num;
        }

        Console.WriteLine($"{num1} {num2}");
    }

    static void Main(string[] args)
    {
        // Example 1
        int[] arr1 = { 1, 2, 3, 2, 1, 4 };
        FindTwoNumbers(arr1);   // Output: 3 4

        // Example 2
        int[] arr2 = { 2, 1, 3, 2 };
        FindTwoNumbers(arr2);   // Output: 1 3

        Console.ReadLine();
    }
}
