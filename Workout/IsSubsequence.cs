namespace Workout;

public static class IsSubsequence
{
    public static bool Main(string s, string t)
    {
        if (s.Length == 0)
            return true;
        
        if (t.Length == 0)
            return false;
        
        var sIndex = 0;
        var tIndex = 0;

        while(tIndex < t.Length){
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;

                if(sIndex == s.Length)
                    return true;
            }

            tIndex++;
        }

        return false;
    }
}