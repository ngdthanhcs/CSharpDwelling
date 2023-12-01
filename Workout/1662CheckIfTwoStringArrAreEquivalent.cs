using System.Security;
using System.Text;

namespace Workout;

public static class CheckIfTwoStringArrAreEquivalent {
    /*public static bool Main(string[] word1, string[] word2)
    {
        /*var w1 = new StringBuilder();
        foreach (var w in word1)
        {
            w1.Append(w);
        }

        word1[0] = w1.ToString();
        w1.Clear();

        foreach (var w in word2)
        {
            w1.Append(w);
        }

        word2[0] = w1.ToString();

        if(word1[0].Length != word2[0].Length)
            return false;

        var l = word1[0].Length;
        for (int i = 0; i < l; i++)
        {
            if (word1[0][i] != word2[0][i])
                return false;
        }

        return true;#1#
        
        /*var w1 = new StringBuilder();
        var w2 = new StringBuilder();
        foreach (var w in word1)
        {
            w1.Append(w);
        }

        foreach (var w in word2)
        {
            w2.Append(w);
        }

        var s1 = w1.ToString();
        var s2 = w2.ToString();

        return s1.Equals(s2);#1#
    }*/
    
    // ??? 
    public static bool ArrayStringsAreEqual(string[] s, string[] t) => s
        .SelectMany(c => c)
        .SequenceEqual(
            t.SelectMany(c => c)
        );

    public static int Add(int a, int b) => a + b;

    public static void Main()
    {
        var c = Add(2, 5);
        Console.WriteLine(c);
    }
}