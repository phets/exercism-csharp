using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (IsSaddlePoint(i, j, matrix)) yield return (i + 1, j + 1);
            }
        }
    }

    private static bool IsSaddlePoint(int row, int column, int[,] matrix)
    {

        int num = matrix[row, column];
        int colLength = matrix.GetLength(0), colMin = Int32.MaxValue;
        int rowLength = matrix.GetLength(1), rowMax = Int32.MinValue;

        for (int i = 0; i < colLength; i++)
        {
            if (matrix[i, column] < colMin)
            {
                colMin = matrix[i, column];
            }
        }
        for (int j = 0; j < rowLength; j++)
        {
            if (matrix[row, j] > rowMax)
            {
                rowMax = matrix[row, j];
            }
        }

        if (colMin == num && rowMax == num) return true;
        return false;
    }
}
