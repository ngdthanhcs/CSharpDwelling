namespace Workout;

public static class CountingBits {
    public static int[] CountBits(int n)
    {
        /*var ans = new int[n + 1];

        ans[0] = 0;
        var curr = 1;
        var end = 1;

        for (int i = 1; i < ans.Length; i++)
        {
            if (end == curr)
            {
                curr = 1;
                end++;
            }

            ans[i] = curr;
            curr++;
        }

        return ans;*/
        
        var ans = new int[n + 1];

        ans[0] = 0;

        for (int i = 1; i < ans.Length; i++)
        {
            ans[i] = i | 2;
        }

        return ans;
    }
}