namespace Workout;

public static class SingleNumberII
{
    public static int singleNumber(int[] nums) {
        int ones = 0;
        int twos = 0;

        foreach (int num in nums) {
            ones ^= (num & ~twos);
            twos ^= (num & ~ones);
            
            Console.WriteLine("num = " + num + "; ones = " + ones + "; twos = " + twos);
        }

        return ones;
    }
}