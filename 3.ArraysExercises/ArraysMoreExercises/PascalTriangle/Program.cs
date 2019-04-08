using System;


class PascalTriangle
{
    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());

        int[][] triangle = new int[height][];
        triangle[0] = new int[1];
        triangle[0][0] = 1;

        for (int row = 0; row < triangle.Length - 1; row++)
        {
            triangle[row + 1] = new int[row + 2];
            for (int col = 0; col <= row; col++)
            {
                triangle[row + 1][col] += triangle[row][col];
                triangle[row + 1][col + 1] += triangle[row][col];
            }
        }
        PrintArrayOfArrays(triangle);

    }

    private static void PrintArrayOfArrays(int[][] triangle)
    {
        for (int row = 0; row < triangle.Length; row++)
        {
            Console.Write("".PadLeft((triangle.Length - row) * 2));
            for (int col = 0; col < triangle[row].Length; col++)
            {
                Console.Write($"{triangle[row][col],3} ");
            }
            Console.WriteLine();
        }
    }
}

