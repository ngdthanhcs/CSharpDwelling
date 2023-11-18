namespace TestIEC;

public static class DemoTask
{
    public static int Main(int[] A)
    {
        var hash = new HashSet<int>(A);

        var ans = 1;

        while (hash.Contains(ans))
            ans++;
        return ans;
    }
}