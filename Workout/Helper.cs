namespace Workout;

public static class Helper
{
    public static void WriteArray(IList<int> list)
    {
        foreach (var i in list)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

public static class DictHelper
{
    public static void AddIfAbsent<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue val)
    {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, val);
        }
    }

    public static void WriteDict(this Dictionary<int, List<int>> dict)
    {
        foreach (var pair in dict)
        {
            Console.Write(pair.Key + " - ");
            foreach (var i in pair.Value)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}