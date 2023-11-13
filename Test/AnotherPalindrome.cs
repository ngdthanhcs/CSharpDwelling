namespace Test;

public static class AnotherPalindrome
{
    public static int countSubstrings(String s) {
        int ans = 0;

        for (int i = 0; i < s.Length; ++i) {
            ans += extendPalindromes(s, i, i);
            ans += extendPalindromes(s, i, i + 1);
        }

        return ans;
    }

    private static int extendPalindromes(String s, int l, int r) {
        int count = 0;
        

        while (l >= 0 && r < s.Length && s[l] == s[r]) {
            ++count;
            --l;
            ++r;
        }

        return count;
    }
}