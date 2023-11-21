using System.Text;

namespace Workout;

public static class CountNicePair {
    public static int CountPair(int[] nums)
    {
        Helper.WriteArray(nums);
        var length = nums.Length;

        var revNums = new int[length];

        for (int i = 0; i < length; i++)
        {
            revNums[i] = Rev(nums[i]);
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = i; j < length; j++)
            {
                if()
            }
        }
        
        Helper.WriteArray(revNums);

        return 0;
    }

    private static int Rev(int num)
    {
        var s = num.ToString();
        var l = s.Length;
        var rev = new StringBuilder(s);
        
        for (int i = 0; i < l; i++)
        {
            rev[i] = s[^(i + 1)];
        }
        return int.Parse(rev.ToString());
    }
}