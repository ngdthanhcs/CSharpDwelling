namespace Workout;

public class MinimumNumberOfStepsToMakeTwoStringsAnagram {
    public int MinSteps(string s, string t)
    {
        /*var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            dict.TryAdd(c, 0);
            dict[c]++;
        }

        foreach (var c in t)
        {
            dict.TryAdd(c, 0);
            dict[c]--;
        }

        var count = 0;
        foreach (var pair in dict)
        {
            count += Math.Abs(pair.Value);
        }

        return count;*/
        
        int[] charFrequency = new int[26];
      
        foreach (var c in s)
        {
            charFrequency[c - 'a']++;
        }
      
        int minSteps = 0;
      
        foreach (var c in t)
        {
            if (--charFrequency[c - 'a'] < 0) {
                minSteps++;
            }
        }
        return minSteps;
    }
}