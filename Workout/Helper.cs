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

    public static void WriteArray(IList<bool> list)
    {
        foreach (var i in list)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void WriteArray(int[,] list)
    {
        for (int i = 0; i < list.GetLength(0); i++)
        {
            for (int j = 0; j < list.GetLength(1); j++)
            {
                //Console.Write("[" + i + "," + j + "]");
                Console.Write(list[i, j] + " ");
            }
            
            //Console.Write("EOL");
            Console.WriteLine();
        }
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