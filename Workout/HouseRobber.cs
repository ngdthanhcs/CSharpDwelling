namespace Workout;

public static class HouseRobber
{
    public static int rob(int[] nums) {
        // approach 1 
        /*int n = nums.Length;
        if (n == 0)
            return 0;
        if (n == 1)
            return nums[0];

        // dp[i] := the maximum money of robbing nums[0..i]
        int[] dp = new int[n];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < n; ++i)
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);

        return dp[n - 1];*/
        
        // O(1) 
        int prev1 = 0;  // dp[i - 1]
        int prev2 = 0;  // dp[i - 2]

        foreach (int num in nums) {
            int dp = Math.Max(prev1, prev2 + num);
            prev2 = prev1;
            prev1 = dp;
        }

        return prev1;
    }
}