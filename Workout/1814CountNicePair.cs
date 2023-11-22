using System.Text;

namespace Workout;

public static class CountNicePair {
    public static int CountPair(int[] nums)
    {
        //return (Reverse(12345));
        var n = nums.Length;
        for (int i = 0; i < n; i++){
            nums[i] -= Reverse(nums[i]);
        }

        var result = 0;
        var dict = new Dictionary<int, int>();
        var mod = 1_000_000_007;
        for (int i = 0; i < n; i++){
            if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], 0);
            dict[nums[i]]++;
            result = (result + dict[nums[i]] - 1) % mod;
        }

        return result;
    }

    private static int Reverse(int x){
        int ans = 0;
        while (x > 0){
            ans *= 10;
            ans += x % 10;
            x /= 10;
        }

        return ans;
    }
}