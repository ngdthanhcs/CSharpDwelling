namespace Workout;

public class DetermineIfStringHalvesAreAlike {
    public bool HalvesAreAlike(string s) {
        var count = 0;
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var halfPoint = s.Length / 2;
        for(var i = 0; i < s.Length; i++)
        {
            if (!vowels.Contains(s[i])) continue;
            if (i < halfPoint)
                count++;
            else
                count--;
        }

        return count == 0;
    }
}