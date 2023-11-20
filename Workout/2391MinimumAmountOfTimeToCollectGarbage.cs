namespace Workout;

public static class MinimumAmountOfTimeToCollectGarbage {
    /*public static int CalMinimumTime(string[] garbage, int[] travel)
    {
        int gPointer = 0, pPointer = 0, mPointer = 0;
        var length = garbage.Length;
        var ans = 0;
        var prevHouse = new HashSet<char>();

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < garbage[i].Length; j++)
            {
                var g = garbage[i][j];
                var freq = garbage[i].Count(c => c == g);
                
                ans += CheckTotalCost(g, 'G', ref gPointer, i, travel, prevHouse, freq);
                ans += CheckTotalCost(g, 'M', ref mPointer, i, travel, prevHouse, freq);
                ans += CheckTotalCost(g, 'P', ref pPointer, i, travel, prevHouse, freq);

                prevHouse = garbage[i].ToHashSet();
            }
        }

        return ans;
    }

    private static int CheckTotalCost(char c, char target, ref int pointer, int i, int[] travel,
        HashSet<char> prevHouse, int freq)
    {
        if (c != target) return 0;
        
        var cost = 0;
        cost += freq;
        if(prevHouse.Contains(c))
            cost += CheckMoveTruck(ref pointer, i, travel);

        return cost;
    }

    private static int CheckMoveTruck(ref int pointer, int i, int[] travel)
    {
        if (pointer >= i) return 0;
        var cost = 0;

        while (pointer < i)
        {
            cost += travel[pointer];
            pointer++;
        }

        return cost;
    }*/

    private static string[] _garbage;
    private static int[] _travel;
    
    public static int garbageCollection(String[] garbage, int[] travel)
    {
        _garbage = garbage;
        _travel = travel;
        
        int ans = 0;
        for (int i = 0; i < garbage.Length - 1; i++) {
            ans += 3 * travel[i];
        }
        foreach (String s in garbage) {
            ans += s.Length;
        }
        SubtractFor(ref ans, 'G');
        SubtractFor(ref ans, 'P');
        SubtractFor(ref ans, 'M');
        
        return ans;
    }

    private static void SubtractFor(ref int ans, char c)
    {
        for (int i = _garbage.Length - 1; i > 0; i--)
        {
            if (!_garbage[i].Contains(c))
            {
                ans -= _travel[i - 1];
            }
            else
            {
                break;
            }
        }
    }
}