namespace HashSet;

public class HashSetTest
{
    public static void Main()
    {
        var set = new HashSet<string>();
        
        set.Add("Hello");

        if (set.Contains("Hello"))
            set.Add("World");
        else
            set.Add("Hello");

        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine(set.Count);
    }
}