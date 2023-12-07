namespace HelperLib;

public static class ArrayHelper
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