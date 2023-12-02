namespace Workout;

public static class NumberOf1Bits {
    public static int Main(uint n)
    {
        // bit manipulation
        /*int ans = 0;

        for (int i = 0; i < 32; ++i)
            if (((n >> i) & 1) == 1)
                ++ans;

        return ans;*/
        
        //Brian Kernighan's Algorithm
        int count = 0;
        while (n != 0) {
            n &= n - 1;
            count++;
        }
        return count;
    }
}