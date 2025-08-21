using System;

class MatrixSearch
{
    public static int matSearch(int[,] mat, int N, int M, int X)
    {
        int i = 0, j = M - 1;

        while (i < N && j >= 0)
        {
            if (mat[i, j] == X)
                return 1;
            else if (mat[i, j] > X)
                j--;  // move left
            else
                i++;  // move down
        }

        return 0;
    }

    static void Main(string[] args)
    {
        // Example 1
        int[,] mat1 = {
            {3, 30, 38},
            {44, 52, 54},
            {57, 60, 69}
        };
        Console.WriteLine(matSearch(mat1, 3, 3, 62)); // Output: 0

        // Example 2
        int[,] mat2 = { { 18, 21, 27, 38, 55, 67 } };
        Console.WriteLine(matSearch(mat2, 1, 6, 55)); // Output: 1

        Console.ReadLine();
    }
}
