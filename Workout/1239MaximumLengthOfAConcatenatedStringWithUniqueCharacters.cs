namespace Workout;

public class MaximumLengthOfAConcatenatedStringWithUniqueCharacters {
    public int maxLength(List<String> arr) {
        List<int> dp = new List<int>();
        dp.Add(0);
        int res = 0;
        foreach (String s in arr) {
            int a = 0, dup = 0;
            foreach (char c in s) {
                dup |= a & (1 << (c - 'a'));
                a |= 1 << (c - 'a');
            }
            if (dup > 0)    continue;
            for (int i = dp.Count - 1; i >= 0; i--) {
                if ((dp[i] & a) > 0) continue;
                dp.Add(dp[i] | a);
                res = Math.Max(res, int.PopCount(dp[i] | a));
            }
        }
        return res;
    }
}