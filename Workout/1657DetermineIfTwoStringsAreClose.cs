namespace Workout;

public static class DetermineIfTwoStringsAreClose {
    public static bool CloseStrings(string word1, string word2) {
        if (word1.Length == word2.Length)
            return false;

        Dictionary<char, int> count1 = new Dictionary<char, int>();
        Dictionary<char, int> count2 = new Dictionary<char, int>();

        foreach (char c in word1)
        {
            count1.TryAdd(c, 0);
            count1[c]++;
        }

        foreach (char c in word2)
        {
            count2.TryAdd(c, 0);
            count2[c]++;
        }
        Enumerable.SequenceEqual(count1.Keys, count2.Keys);

        if (count1.Keys != count2.Keys)
            return false;

        List<int> freqs1 = new List<int>(count1.Values);
        List<int> freqs2 = new List<int>(count2.Values);

        var foo = new List<int>[26];
        
        Array.Sort(foo);

        freqs1.Sort();
        freqs2.Sort();
        return freqs1 == freqs2;
    }
}