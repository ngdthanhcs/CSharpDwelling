namespace Workout;

public class FindPlayersWithZeroOrOneLose {
    public IList<IList<int>> FindWinners(int[][] matches) {
        IList<IList<int>> ans = new List<IList<int>>();
        ans.Add(new List<int>());
        ans.Add(new List<int>());
        Dictionary<int, int> lossesCount = new Dictionary<int, int>();

        foreach (int[] m in matches) {
            int winner = m[0];
            int loser = m[1];
            /*if (!lossesCount.containsKey(winner))
                lossesCount.put(winner, 0);*/

            lossesCount.TryAdd(winner, 0);
            lossesCount.TryAdd(loser, 0);
            lossesCount[loser]++;
        }

        Console.WriteLine("Phase 2");

        foreach ( int player in lossesCount.Keys) { 
            int nLosses = lossesCount[player];
            if (nLosses < 2)
                ans[nLosses].Add(player);
        }

        var foo = ans[1].ToList();
        foo.Sort();
        ans[1] = foo;

        return ans;
    }
}