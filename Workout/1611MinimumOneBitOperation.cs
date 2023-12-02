namespace Workout;

public static class MinimumOneBitOperation {
    static Dictionary<int, int> map = new Dictionary<int, int>();
    static HashSet<int> set = new HashSet<int>();

    public static int Main(int n) {
        map.Add(0, 0);
        int maxPow2 = 1;
        while (maxPow2 <= n){
            map.Add(maxPow2, 0);
            map[maxPow2] = map[maxPow2 / 2 * 2 + 1];
            set.Add(maxPow2);
            maxPow2 <<= 1;
        }
        return calculate(n);
    }

    public static int calculate(int n) {
        if (!map.ContainsKey(n)) {
            int low = set.MinBy(s => s <= n);
            int operations = calculate(low) - calculate(n - low);
            map.Add(n, operations);
        }
        return map[n];
    }
    
    // gray code magic 
    /*public static int Main(int n) {
        int ans = 0;
        while (n > 0) {
            ans ^= n;
            n >>= 1;
            Console.WriteLine("ans: " + ans + "n: " + n);
        }
        return ans;
    }*/
}