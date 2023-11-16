using System.Numerics;

namespace Workout;

public static class MaxElementAfterDecreasingAndRearranging {
    public static int MaxElementAfterModifyArr(int[] arr)
    {
        // naive 
        /*Array.Sort(arr);
        arr[0] = 1;

        for (int i = 1; i < arr.Length; ++i)
            arr[i] = Math.Min(arr[i], arr[i - 1] + 1);

        return arr[^1];*/
        
        // ? 
        
        int l = arr.Length;
        int[] counter = new int[l];
        for(int i=0;i<l;i++)
        {
            ++counter[Math.Min(arr[i]-1,l-1)];
        }
        int ans = 1;
        for(int i=1;i<l;i++)
        {
            ans = Math.Min(i+1,ans+counter[i]);
        }
        return ans;
    }
}