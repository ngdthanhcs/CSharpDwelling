namespace Workout;

public static class CountNumberOfHomogenousSubstrings {
    public static int CountHomogenous(string s)
    {
        int kMod = 1_000_000_007;
        Console.WriteLine(kMod);
        int ans = 0;
        int count = 0;
        char currentChar = '@';

        foreach (char c in s) {
            count = c == currentChar ? count + 1 : 1;
            currentChar = c;
            ans += count;
            Console.WriteLine(count);
            ans %= kMod;
        }

        return ans;
    }
}