namespace Workout;

public static class AthrimeticSubarray {
    public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var ans = new List<bool>();
        for (int i = 0; i < l.Length; i++)
        {
            ans.Add(CheckArthimetic(nums, l[i], r[i]));
        }

        return ans;
    }

    private static bool CheckArthimetic(int[] nums, int l, int r)
    {
        //Helper.WriteArray(subArray);
        if (r - l < 2)
            return true;

        int min = int.MaxValue;
        int max = int.MinValue;
        var numsSet = new HashSet<int>();

        for (int i = l; i <= r; ++i) {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
            numsSet.Add(nums[i]);
        }

        if ((max - min) % (r - l) != 0)
            return false;

        int interval = (max - min) / (r - l);

        for (int k = 1; k <= r - l; ++k)
            if (!numsSet.Contains(min + k * interval))
                return false;

        return true;
    }

    /*private static bool IsOdd(this int x)
    {
        return (x & 1) != 0;
        
        // return x % 2 != 0;
    }

    private static float[] SubArray(this int[] nums, int l, int r)
    {
        var ans = new float[r - l + 1];

        for (int i = l, index = 0; i <= r; i++, index++)
        {
            ans[index] = nums[i];
        }

        return ans;
    }*/
}