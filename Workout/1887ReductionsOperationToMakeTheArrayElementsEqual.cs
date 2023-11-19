namespace Workout;

public static class ReductionsOperationToMakeTheArrayElementsEqual {
    public static int CalculateReductionsOperation(int[] nums)
    {
        Array.Sort(nums);
        var length = nums.Length;
        var minIndex = 0;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != nums[0])
            {
                minIndex = i;
                break;
            }
        }

        if (minIndex == 0 && nums[0] == nums[1])
            return 0;
        
        var currCount = 0;
        var ans = 0;

        for (int i = minIndex; i < length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                currCount++;
            }

            ans += currCount;
        }

        return ans;
    }
}