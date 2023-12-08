namespace HelperLib;

public static class DictHelper
{
    public static void AddIfAbsent<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue val)
    {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, val);
        }
    }

    public static void WriteDict<TKey, TValue>(this Dictionary<TKey, List<TValue>> dict)
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
    
    public static void WriteDict<TKey, TValue>(this Dictionary<TKey, TValue> dict)
    {
        foreach (var pair in dict)
        {
            Console.Write(pair.Key + " - " + dict[pair.Key]);
            Console.WriteLine();
        }
    }
}