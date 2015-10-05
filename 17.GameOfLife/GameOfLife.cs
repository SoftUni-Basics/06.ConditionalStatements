using System;

class GameOfLife
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] matrix = new int[10];
        
        for (int i = 0; i < n; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            matrix[row] |= 1 << col;
        }

        int[] result = new int[10];
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = matrix.Length - 1; col >= 0; col--)
            {
                int neighbourCounter = 0;
                neighbourCounter = NeighboursChecker(matrix, row, col);
                if (neighbourCounter == 3 && ((matrix[row] >> col) & 1) == 0)
                {
                    result[row] |= 1 << col;
                }
                else if ((neighbourCounter >= 2 && neighbourCounter <= 3) && ((matrix[row] >> col) & 1) == 1)
                {
                    result[row] |= 1 << col;
                }
            }
        }

        for (int row = 0; row < result.Length; row++)
        {
            Console.WriteLine(Convert.ToString(result[row], 2).PadLeft(10, '0'));
        }
    }

    static int NeighboursChecker(int[] matrix, int row, int col)
    {
        int count = 0;
        for (int r = row - 1; r <= row + 1; r++)
        {
            for (int c = col - 1; c <= col + 1; c++)
            {
                if (r == row && c == col){}
                else if ((r >= 0 && r < 10) && (c >= 0 && c < 10) && ((matrix[r] >> c) & 1) == 1)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
