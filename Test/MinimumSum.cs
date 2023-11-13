namespace Test;

public static class MinimumSum
{
    public static int minSum(List<int> num, int k)
    {
        num.Sort();
        num.Reverse();
        var index = 0;

        while (k > 0)
        {
            num[index] = (int) MathF.Ceiling((float)num[index] / 2);
            
            Console.WriteLine("index = " + index);
            foreach (var i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            if (index >= num.Count - 1) index = 0;
            
            if (index + 1 < num.Count && num[index] < num[index + 1]) index++;
            k--;
        }

        return num.Sum();
    }

    public static int YetAnotherMinSum(List<int> num, int k)
    {
        var freq = new int[10001];

        foreach (var i in num)
        {
            freq[i]++;
        }
 
        var ans=0;
        for(var i = 10000; i >= 1; i--){
            var count = Math.Min(freq[i],k);
            
            freq[i] -= count;
            freq[(i + 1) / 2]+=count;
            k-=count;
            ans+= i * freq[i];
            
            //Console.WriteLine(k + " " + ans);
        }
        
        return ans;
    }
    
    public static int AnotherMinSum(List<int> num, int k)
    {
        var queue = num.ToList();

        queue.Sort();
        while (queue.Count != 0 && k > 0)
        {
            queue[^1] = (int) MathF.Ceiling((float)queue[^1] / 2);
         
            k--;
            queue.Sort();
        }
        
        var sum = 0;
        while (queue.Count != 0)
        {
            sum += queue[0];
            queue.RemoveAt(0);
        }
        return sum;
    }
}