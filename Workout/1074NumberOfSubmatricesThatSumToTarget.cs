namespace Workout;

public class NumberOfSubmatricesThatSumToTarget
{
    public int numSubmatrixSumTarget(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int ans = 0;

        // Transfer each row in the matrix to the prefix sum.
        foreach (int[] row in matrix)
            for (int i = 1; i < n; ++i)
                row[i] += row[i - 1];

        for (int baseCol = 0; baseCol < n; ++baseCol)
        for (int j = baseCol; j < n; ++j)
        {
            Dictionary<int, int> prefixCount = new Dictionary<int, int>();
            prefixCount.Add(0, 1);
            int sum = 0;
            for (int i = 0; i < m; ++i)
            {
                if (baseCol > 0)
                    sum -= matrix[i][baseCol - 1];
                sum += matrix[i][j];
                if (prefixCount.ContainsKey(sum - target))
                    ans += prefixCount[sum - target];
                
                prefixCount.TryAdd(sum, 1);
                prefixCount[sum] += sum;
            }
        }

        return ans;
    }
}