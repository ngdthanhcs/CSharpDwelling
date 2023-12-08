using HelperLib;

namespace CSharpDwelling;

public static class TestDict
{
    public static void Main()
    {
        var dict = new Dictionary<string, int>();

        dict["Moors"] = 13;
        dict.Add("Moors", 5);

        dict.WriteDict();
    }    
}