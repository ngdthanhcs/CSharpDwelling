namespace Workout;

public static class MinimizeMaximumPairSumInArray {
    public static int MinimizeMaximumPair(int[] nums)
    {
        Array.Sort(nums);

        var max = 0;

        for (int i = 0; i < nums.Length / 2; i++)
        {
            if (nums[i] + nums[^i] > max) max = nums[i] + nums[^i];
        }

        return max;
    }
    
}