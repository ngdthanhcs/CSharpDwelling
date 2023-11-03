namespace Workout;

public class KWeakestRow
{
    public static int[] Main(int[][] mat, int k)
    {
        var ans = new int[k];
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                Console.Write(mat[i][j] + " ");
            }
            Console.WriteLine();
        }

        return ans;
    }
}