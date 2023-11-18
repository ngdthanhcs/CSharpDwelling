using System.Runtime.CompilerServices;

namespace TestIEC;

public static class ShortestSubArrayBetweenLAndR
{
    public static int Solution(int[] A, int L, int R)
    {
        // cach 1:
        // 2 1 4 3 2 1 1 4
        // i 2 -> ++ 
        // i 1 -> 0 
        // i 4 -> ++ used Add 4 
        // i 3 -> ++ used Add 3 
        // i 2 -> ++ used Add 2 -> used length == 3 -> min = length
        // i length left == 3 end
        
        // -> 
        // 2 1 4 3 2 1 1 4 
        //     |   | -> 3 
        //           | | lengthLeft == 3 -> end
        //             | | 
        
        // 99 1 1 1 1 1 1 99 
        // 
        // list of (A[i], index)
        /*var list = new List<(int, int)>();

        for (int i = 0; i < A.Length; i++)
        {
            if(A[i] >= L && A[i] <= R)
                list.Add((A[i], i));
        }

        var used = new HashSet<int>();
        var min = A.Length + 1;
        var from = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if (!used.Contains(list[i].Item1))
            {
                used.Add(list[i].Item1);
            }

            if (used.Count == R - L + 1)
            {
                var length = list[i].Item2 - list[from].Item2 + 1;
                min = length < min ? length : min;

                used.Remove(list[from].Item1);
                from++;
            }
        }

        return min > A.Length ? -1 : min;*/

        var used = new HashSet<int>();

        var from = 0;
        if (Check(A[from], L, R)) used.Add(A[from]);
        var to = 1;

        var min = A.Length + 1;

        while (from < A.Length - 2 && to < A.Length - 1)
        {
            to++;
            if (Check(A[to], L, R) && !used.Contains(A[to])) used.Add(A[to]);
            if (used.Count == R - L + 1)
            {
                var length = to - from + 1;
                min = length < min ? length : min;

                while (from < to - 1)
                {
                    used.Remove(A[from]);
                    from++;
                }
            }
        }

        return min > A.Length ? -1 : min;
    }

    private static bool Check(int i, int L, int R)
    {
        return i >= L && i <= R;
    }
}