namespace Workout;

public static class ReductionsOperationToMakeTheArrayElementsEqual {
    public static int CalculateReductionsOperation(int[] nums)
    {
        // 1--------- naive 
        /*Array.Sort(nums);
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

        return ans;*/
        
        // 2-------- count frequencies
        int n = nums.Length;
        int[] freq = new int[50001];
        for (int i = 0; i < n; i++) {
            freq[nums[i]]++;
        }
        int ans = 0, operations = 0;
        for (int i = 50000; i >= 1; i--)
        {
            if (freq[i] <= 0) continue;
            operations += freq[i];
            ans += operations - freq[i];
        }
        return ans;
    }
}