namespace Workout;

public static class MaximumNumberOfCoinsYouCanGet {
    public static int MaxNumberOfCoin(int[] piles)
    {
        var n = piles.Length;

        var max = piles.Max();

        var freq = new int[max+1];

        foreach(var a in piles)
        {
            freq[a]++;
        }
        
        var coins = 0;
        var chance = n / 3;

        var turn = 1;
        var i = max;

        while(chance > 0){
            if(freq[i] > 0){
                if(turn == 1) turn = 0;
                else {
                    chance--;
                    turn = 1;
                    coins += i;
                }
                freq[i]--;
            }else{
                i--;
            }
        }

        return coins;
        Array.Sort(piles);/*
        var l = piles.Length;
        var ans = 0;

        for (int i = l / 3; i < l; i += 2)
            ans += piles[i];

        return ans;*/
    }
}