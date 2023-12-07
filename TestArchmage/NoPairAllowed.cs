namespace Test;

public static class NoPairAllowed
{
    public static List<int> minimalOperations(List<string> words)
    {
        var ans = new List<int>();

        foreach (var w in words)
        {
            ans.Add(FindMinimal(w));
        }

        return ans;
    }

    private static int FindMinimal(string s)
    {
        var ans = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                ans++;
                i++;
            }
        }

        return ans;
    }
}