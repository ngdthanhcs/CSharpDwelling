namespace Workout;

public class MinimumDeletion
{
    // Ot(n)
    // Os(1)
    public static int MinDeletions(String s) {
        var ans = 0;
        var count = new int[26];
        var usedFreq = new HashSet<int>();

        foreach (var c in s)
        {
            ++count[c - 'a'];
        }

        foreach (var t in count)
        {
            var freq = t;
            while (freq > 0 && usedFreq.Contains(freq)) {
                freq--; // Delete ('a' + i).
                ++ans;
            }
            
            usedFreq.Add(freq);
        }

        return ans;
    }
}