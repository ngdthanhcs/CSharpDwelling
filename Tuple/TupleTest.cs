namespace Tuple;

public class TupleTest
{
    public static int TrueMinDeletions(String s) {
        var ans = 0;
        var count = new int[26];
        var usedFreq = new HashSet<int>();

        foreach (var c in s)
        {
            ++count[c - 'a'];
        }

        for (int i = 0; i < count.Length; i++)
        {
            var freq = count[i];
            while (freq > 0 && usedFreq.Contains(freq)) {
                freq--; // Delete ('a' + i).
                ++ans;
            }
            
            usedFreq.Add(freq);
        }

        return ans;
    }
    
    public static int MinDeletions(string s) {
        var (dict, max) = PreCalculate(s);

        foreach (var kvp in dict) {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

        var list = CalculateList(max, dict);
        
        foreach(var l in list){
            Console.Write(list.Count);
            Console.Write("[");
            foreach(var c in l){
                Console.Write(c + ",");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        var result = 0;

        while (!IsDone(list))
        {
            
        }

        return 0;
    }

    private static bool IsDone(List<List<char>> list)
    {
        foreach (var l in list)
        {
            if (l.Count != 1)
                return false;
        }

        return true;
    }

    private static (Dictionary<char, int> dict, int max) PreCalculate(string s)
    {
        var dict = new Dictionary<char, int>();
        var max = 0;
        
        foreach(char c in s){
            if(!dict.ContainsKey(c)){
                dict.Add(c, 1);
            }
            else{
                dict[c]++;

                if(dict[c] > max)
                    max = dict[c];
            }
        }

        return (dict, max);
    }

    private static List<List<char>> CalculateList(int max, Dictionary<char, int> dict)
    {
        var list = new List<List<char>> { new() };
        
        for(var i = 1; i <= max; i++){
            try{
                var matches = dict.Where(pair => pair.Value == i)
                    .Select(pair => pair.Key);

                if(list.Count <= i)
                {
                    list.Add(new List<char>());
                    //Console.WriteLine("added on " + i + ", new length = " + list.Count);
                }

                if(!matches.Any())
                    continue;

                list[i].AddRange(matches);

                //Console.WriteLine("i = " + i + " matches = " + matches.Count());
            } catch(Exception e){
                Console.WriteLine("ERR: i = " + i + "list length = " + list.Count);
            }
            //Console.WriteLine("Done Loop");
        }

        return list;
    }
}