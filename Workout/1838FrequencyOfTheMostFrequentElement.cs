namespace Workout;

public static class FrequencyOfTheMostFrequentElement
{
    public static int MaxFrequency(int[] nums, int k)
    {
        /*var length = nums.Length;
        Array.Sort(nums);
        var lack = new int[length - 1];
        lack[0] = nums[1] - nums[0];

        for (int i = 1; i < length - 1; i++)
        {
            var sumIndex = i + 1;
            lack[i] = lack[i-1] + sumIndex * (nums[sumIndex] - nums[sumIndex - 1]);
        }

        for (int i = length - 2; i >= 0; i--)
        {
            if (k >= lack[i])
                return i + 2; 
        }

        return 1;*/
        
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