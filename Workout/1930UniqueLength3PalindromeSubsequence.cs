using System.Runtime.InteropServices.ComTypes;

namespace Workout;

public static class UniqueLength3PalindromeSubsequence {
    public static int CountPalindromicSubsequence(String s) {
        int ans = 0;
        int[] first = new int[26];
        int[] last = new int[26];

        Array.Fill(first, s.Length);

        for (int i = 0; i < s.Length; ++i) {
            int index = s[i] - 'a';
            first[index] = Math.Min(first[index], i);
            last[index] = i;
        }

        for (int i = 0; i < 26; ++i)
            if (first[i] < last[i])
            {
                var substrings = s.Substring(first[i] + 1, last[i] - first[i] - 1);
                var charArr = substrings.ToCharArray();
                var distinct = charArr.Distinct();
                var count = distinct.Count();
                ans += count;
            }
        return ans;
    }
}