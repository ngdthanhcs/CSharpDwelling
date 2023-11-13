using System.Runtime.InteropServices.JavaScript;

namespace Workout;

public static class RestoreArrFromAdjacentPair {
    public static int[] RestoreArray(int[][] adjacentPairs)
    {
        int[] ans = new int[adjacentPairs.Length + 1];
        int i = 0; // ans's index
        /*Dictionary<int, List<Integer>> */ var numToAdjs = new Dictionary<int, List<int>>();

        foreach (var pair in adjacentPairs) {
            numToAdjs.AddIfAbsent(pair[0], new List<int>());
            numToAdjs.AddIfAbsent(pair[1], new List<int>());
            
            numToAdjs[pair[0]].Add(pair[1]);
            numToAdjs[pair[1]].Add(pair[0]);
        }

        foreach (var entry in numToAdjs)
        {
            if (entry.Value.Count == 1)
            {
                ans[i++] = entry.Key;
                ans[i++] = entry.Value[0];
                break;
            }
        }

        while (i < adjacentPairs.Length + 1) {
            int tail = ans[i - 1];
            int prev = ans[i - 2];
            List<int> adjs = numToAdjs[tail];
            if (adjs[0] == prev)
                ans[i++] = adjs[1];
            else
                ans[i++] = adjs[0];
        }

        return ans;
    }
}