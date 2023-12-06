using System.Text;

namespace Workout;

public static class Largest3SameDigitNumberInString {
    public static string Main(string num)
    {
        var ans = -1;
        var checking = -1;
        var count = 0;
        foreach (var c in num)
        {
            var i = c - '0';
            if (i != checking)
            {
                checking = i;
                count = 1;
            }
            else if (i == checking)
                count++;

            if (count == 3 && checking > ans)
                ans = checking;
        }

        return ans == -1 ? "" : new StringBuilder(3).Append(ans).Append(ans).Append(ans).ToString();
        
        /*for (var i=9; i>=0; i--)
        {
            var sub = $"{i}{i}{i}";

            if (num.Contains(sub)) return sub;
        }
        return "";*/
    }
}