namespace Workout;

public class LongestCommonSubsequence {
    public int longestCommonSubsequence(String text1, String text2) {
        int m = text1.Length;
        int n = text2.Length;
        // dp[i][j] := the length of LCS(text1[0..i), text2[0..j))
        int[,] dp = new int[m + 1,n + 1];

        for (int i = 0; i < m; ++i)
        for (int j = 0; j < n; ++j)
            dp[i + 1,j + 1] = text1[i] == text2[j]
                ? 1 + dp[i,j]
                : Math.Max(dp[i,j + 1], dp[i + 1,j]);

        return dp[m,n];
        
        /*var l = text1.Length;
        var l2 = text2.Length;

        if(l2 > l){
            (text1, text2) = (text2, text1);
            (l, l2) = (l2, l);
        }

        Console.WriteLine(text1);

        var dict1 = new Dictionary<char, Queue<int>>();

        for(int i = 0; i < l; i++){
            dict1.TryAdd(text1[i], new Queue<int>());

            dict1[text1[i]].Enqueue(i);
        } 

        foreach(var pair in dict1){
            Console.WriteLine(pair.Key + " " + pair.Value.Count);
        }

        var t = 0;
        var lastIndex = -1;

        Console.WriteLine("---------");

        var lO = new List<int>();

        for(int i = 0; i < l2; i++){
            if(dict1.ContainsKey(text2[i]) && dict1[text2[i]].Count > 0){
                var pos = dict1[text2[i]].Dequeue();
                lO.Add(pos);
            }
        } 

        l = lO.Count;

        if(l == 0)
            return 0;
        lastIndex = -1;

        foreach(var i in lO){
            Console.WriteLine(i);
        }

        for(int i = 1; i < l; i++){
            if(lO[i] > lO[i-1])
                t++;
            else{
                lastIndex = Math.Max(t, lastIndex);
                t = 0;
            }
        }

        return Math.Max(t, lastIndex) + 1; */
    }
}