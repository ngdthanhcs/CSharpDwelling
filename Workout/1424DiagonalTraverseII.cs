namespace Workout;

public static class DiagonalTraverseII {
    public static int[] FindDiagonalOrder(List<List<int>> nums) {
        List<int> ans = new List<int>();
        var keyToNums = new Dictionary<int, List<int>>(); // Key = row + col
        int maxKey = 0;

        for (int i = 0; i < nums.Count; ++i)
        for (int j = 0; j < nums[i].Count; ++j) {
            int key = i + j;
            if(!keyToNums.ContainsKey(key))
                keyToNums.Add(key, new List<int>());
            keyToNums[key].Add(nums[i][j]);
            maxKey = Math.Max(key, maxKey);
        }

        for (int i = 0; i <= maxKey; ++i)
        for (int j = keyToNums[i].Count - 1; j >= 0; --j)
        {
            Console.WriteLine(keyToNums[i][j]);
            ans.Add(keyToNums[i][j]);
            
            Console.Write("ans = ");
            Helper.WriteArray(ans);
        }

        return ans.ToArray();
    }
}