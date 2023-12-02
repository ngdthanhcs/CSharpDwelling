namespace Workout;

public static class FindWordsThatCanBeFormedByCharacters {
    public static int Main(string[] words, string chars)
    {
        var ans = 0;
        var l = words.Length;
        
        var charDict = new int[26];
        foreach (var c in chars)
        {
            charDict[c - 'a']++;
        }
        
        var dict = new int[l , 26];

        for (int i = 0; i < l; i++)
        {
            var w = words[i];
            var broken = false;
            foreach (var c in w)
            {
                var index = c - 'a';
                dict[i, index]++;
                
                if(dict[i, index] > charDict[index])
                {
                    broken = true;
                    break;
                }
            }

            if (!broken)
                ans += w.Length;
        }

        return ans;
    }
}