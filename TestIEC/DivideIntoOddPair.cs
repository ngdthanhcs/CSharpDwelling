namespace TestIEC;

public static class DivideIntoOddPair
{
    public static bool DividePair(int[] A)
    {
        var oddCount = 0;
        var evenCount = 0;
        foreach (var i in A)
        {
            if ((i & 1) == 0)
                evenCount++;
            else
                oddCount++;
        }

        return oddCount == evenCount;
    }
}