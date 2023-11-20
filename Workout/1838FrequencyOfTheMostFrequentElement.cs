namespace Workout;

public static class FrequencyOfTheMostFrequentElement
{
    public static int MaxFrequency(int[] nums, int k)
    {
        // sliding window with dynamic width 
        // -> O(nlogk)
        int ans = 0;
        long sum = 0;

        Array.Sort(nums);

        for (int l = 0, r = 0; r < nums.Length; ++r) {
            sum += nums[r];
            while (sum + k < (long) nums[r] * (r - l + 1))
                sum -= nums[l++];
            ans = Math.Max(ans, r - l + 1);
        }

        return ans;
    }
}