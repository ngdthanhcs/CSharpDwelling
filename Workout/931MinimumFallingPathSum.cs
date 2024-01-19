namespace Workout;

public static class MinimumFallingPathSum
{
    /*private static int length;
    
    public static int MinFallingPathSum(int[][] matrix)
    {
        var min = 0;
        length = matrix.GetLength(0);
        for (var k = 0; k < length; k += 1) {
            min += (matrix[k][0]);
        }
        
        foreach(var i in matrix[0])
        {
            var runDown = RunDown(0, i, i, matrix);
            min = min < runDown
                ? min 
                : runDown;
        }

        return min;
    }

    private static int RunDown(int row, int col, int currSum, int[][] matrix)
    {
        try
        {
            if (row == length)
            {
                return currSum;
            }

            currSum += matrix[row][col];

            for (int i = -1; i < 2; i++)
            {
                var calCol = col + i;
            
                if(calCol < 0 || calCol >= length)
                    continue;

                var runDown = RunDown(row + 1, calCol, currSum, matrix);
            
                currSum = currSum < runDown
                    ? currSum 
                    : runDown;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return currSum;
    }*/
    
    public static int MinFallingPathSum(int[][] matrix) {
        
        int n = matrix.Length;

        for (int i = 1; i < n; ++i)
        for (int j = 0; j < n; ++j) {
            int min = int.MaxValue;
            for (int k = Math.Max(0, j - 1); k < Math.Min(n, j + 2); ++k)
                min = Math.Min(min, matrix[i - 1][k]);
            matrix[i][j] += min;
        }

        return (matrix[n - 1]).Min();
    }
}