namespace Test;

public static class SubPalindrome
{
    public static int palindrome(string s)
    {
        var ans = 0;
        var count = new int[26];

        foreach (var c in s)
        {
            ++count[c - 'a'];
            if (count[c - 'a'] == 1)
            {
                ans++;
            }
        }

        var used = new HashSet<string>();
        
        for(int i = 0; i < s.Length; i++){
            for(int j = s.Length - i; j > 1; j--)
            {
                var substring = s.Substring(i, j);
                if(!used.Contains(substring) && IsPalin(substring)){
                    Console.WriteLine("palin = " + substring);
                    used.Add(substring);
                    ans++;
                }
            }
        }
        
        /*Console.WriteLine("--1");
        Console.WriteLine(IsPalin("mom"));
        Console.WriteLine("--2");
        Console.WriteLine(IsPalin("mok"));
        Console.WriteLine("--3");*/
        return ans;
    }
    
    private static bool IsPalin(string s){
        return s.Equals(Reverse(s));
    }
    
    public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}