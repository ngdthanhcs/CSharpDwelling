namespace SkipList;

public static class Test
{
    public static void Main()
    {
        var h = new HashSet<int>();

        h.Add(1);
        h.Add(2);

        Console.WriteLine(h.ToString());
        Console.WriteLine("Does contain 1 ? " + h.Contains(1));

        foreach (var i in h)
        {
            Console.WriteLine(i);
        }
    }
}