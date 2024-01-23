namespace Workout;

public class SumsOfSubarrayMinimum {
    public int sumSubarrayMins(int[] arr) {
         int kMod = 1_000_000_007;
         int n = arr.Length;
        long ans = 0;
        // prevMin[i] := index k s.t. arr[k] is the previous minimum in arr[:i]
        int[] prevMin = new int[n];
        // nextMin[i] := index k s.t. arr[k] is the next minimum in arr[i + 1:]
        int[] nextMin = new int[n];
        Stack<int> stack = new Stack<int>();

        Array.Fill(prevMin, -1);
        Array.Fill(nextMin, n);

        for (int i = 0; i < arr.Length; ++i) {
            while (stack.Count != 0 && arr[stack.Peek()] > arr[i]) {
                 int index = stack.Pop();
                nextMin[index] = i;
            }
            if (stack.Count != 0)
                prevMin[i] = stack.Peek();
            stack.Push(i);
        }

        for (int i = 0; i < arr.Length; ++i) {
            ans += (long) arr[i] * (i - prevMin[i]) * (nextMin[i] - i);
            ans %= kMod;
        }

        return (int) ans;
    }
}