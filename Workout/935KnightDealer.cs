namespace Workout;

public static class KnightDealer
{
    static int mod = (int) 1e9 + 7;
    static int[][] MOVES = {
        /*0*/new [] {4, 6},
        /*1*/new [] {6, 8},
        /*2*/new [] {7, 9},
        /*3*/new [] {4, 8},
        /*4*/new [] {0, 3, 9},
        /*5*/Array.Empty<int>(),
        /*6*/new [] {0, 1, 7},
        /*7*/new [] {2, 6},
        /*8*/new [] {1, 3},
        /*9*/new [] {2, 4}
    };
    static int[,] cache = new int[5001, 10];
     
    public static int knightDialer(int n) {
        return knightDialer(n, new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
    }

    static int knightDialer(int remaining, int[] nextNumbers) {
        if (remaining == 1) return nextNumbers.Length;
        int count = 0;

        foreach (int nextNumber in nextNumbers) {
            int cur = cache[remaining, nextNumber];
            if (cur == 0) {
                cur = knightDialer(remaining - 1, MOVES[nextNumber]);
                cache[remaining, nextNumber] = cur;
            }
            count += cur;
            count %= mod;
        }
        return count;
    }
    //-----------------------
    /*public static int CalculateKnightDialer(int n) {
        int kMod = 1_000_000_007;
        int[][] dirs = {new []{-2, 1}, new []{-1, 2}, new []{1, 2}, new []{2, 1}, new []{2, -1}, new []{1, -2}, new []{-1, -2}, new []{-2, -1}};
        // dp[i][j] := the number of ways to stand on (i, j)
        var dp = new int[4, 3];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dp[i, j] = 1;
            }
        }

        dp[3, 0] = 0; dp[3, 2] = 0;

        for (int k = 0; k < n - 1; ++k) {
            var newDp = new int[4, 3];
            for (int i = 0; i < 4; ++i)
            for (int j = 0; j < 3; ++j) {
                if (isNotNumericCell(i, j))
                    continue;
                foreach (var  dir in dirs) {
                    int x = i + dir[0];
                    int y = j + dir[1];
                    if (x < 0 || x >= 4 || y < 0 || y >= 3)
                        continue;
                    if (isNotNumericCell(x, y))
                        continue;
                    newDp[i, j] = (newDp[i, j] + dp[x, y]) % kMod;
                }
            }
            dp = newDp;
        }
        
        Helper.WriteArray(dp);

        int ans = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ans += dp[i, j];
                ans %= kMod;
            }
        }

        return ans;
    }

    private static bool isNotNumericCell(int i, int j) {
        return i == 3 && (j == 0 || j == 2);
    }*/
    //---------------------------
    /*private static HashSet<int> _used = new();
    
    public static int GetNumberOfDeal(int n)
    {
        var ans = 0;
        ans += StartDP(0, n);
        ans += StartDP(1, n);
        ans += StartDP(2, n);
        ans += StartDP(3, n);
        ans += StartDP(4, n);
        ans += n > 1 ? 0 : 1;
        ans += StartDP(6, n);
        ans += StartDP(7, n);
        ans += StartDP(8, n);
        ans += StartDP(9, n);

        return ans;
    }
    
    private static int StartDP(int startingTile, int moveLeft)
    {
        _used.Clear();
        var ans = DPKnightDealer(startingTile, moveLeft);

        return ans;
    }

    private static int DPKnightDealer(int startingTile, int moveLeft)
    {
        if (_used.Contains(startingTile))
            return 0;
        
        if (moveLeft == 0)
            return 1;
        
        return DPKnightDealer()
    }*/
}