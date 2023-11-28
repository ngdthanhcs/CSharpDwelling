namespace Workout;

public static class SumsOfAbsoluteDifference {
    public static int[] SumsAbsoluteDifference(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[n];
        var prefix = new int[n];
        var suffix = new int[n];

        prefix[0] = nums[0];
        for (var i = 1; i < n; ++i)
            prefix[i] = prefix[i - 1] + nums[i];

        suffix[n - 1] = nums[n - 1];
        for (var i = n - 2; i >= 0; --i)
            suffix[i] = suffix[i + 1] + nums[i];
        
        /*Console.Write("prefix: ");
        Helper.WriteArray(prefix);
        Console.Write("suffix: ");
        Helper.WriteArray(suffix);*/

        for (var i = 0; i < nums.Length; ++i) {
            var left = nums[i] * (i + 1) - prefix[i];
            var right = suffix[i] - nums[i] * (n - i);
            ans[i] = left + right;
        }

        return ans;
    }
}