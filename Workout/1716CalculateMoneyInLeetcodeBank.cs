using System.Diagnostics.SymbolStore;

namespace Workout;

public static class CalculateMoneyInLeetcodeBank {
    public static int Main(int n)
    {
        var remainder = n % 7;
        var value = n / 7;
        var total = value + (remainder == 0 ? 0 : 1);
        var bufferSum = 0;

        for (int i = 0; i < total; i++)
        {
            bufferSum += i;
        }
        var sum = 28 * total + 7 * bufferSum;
        if (remainder == 0)
        {
            return sum;
        }

        for (int i = 7; i > remainder; i--)
        {
            sum -= i + value;
        }

        return sum;
    }
}