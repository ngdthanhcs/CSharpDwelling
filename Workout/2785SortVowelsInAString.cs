using System.Text;

namespace Workout;

public static class SortVowelsInAString {
    public static string SortVowels(string s)
    {
        freq = new int[10];
        pos = new List<int>();
        for(int i = 0; i< s.Length; i++)
        {
            IsVowel(s[i], i);
        }

        var freqIndex = 0;
        var sb = new StringBuilder(s);

        for (int i = 0; i < pos.Count; i++)
        {
            while (freq[freqIndex] == 0)
                freqIndex++;

            sb[pos[i]] = "AEIOUaeiou"[freqIndex];
            freq[freqIndex]--;
        }

        return sb.ToString();
    }

    private static int[] freq;
    private static List<int> pos;

    private static void IsVowel(char c, int idx){
        switch(c){
            case 'A': freq[0]++; pos.Add(idx); break;
            case 'E': freq[1]++; pos.Add(idx); break;
            case 'I': freq[2]++; pos.Add(idx); break;
            case 'O': freq[3]++; pos.Add(idx); break;
            case 'U': freq[4]++; pos.Add(idx); break;
            case 'a': freq[5]++; pos.Add(idx); break;
            case 'e': freq[6]++; pos.Add(idx); break;
            case 'i': freq[7]++; pos.Add(idx); break;
            case 'o': freq[8]++; pos.Add(idx); break;
            case 'u': freq[9]++; pos.Add(idx); break;
        }
    }
    
    /*public string SortVowels(string s) {
        var arr = new int[10];
        for(int i = 0; i< s.Length; i++){
            if(IsVowel(s[i])){
                listChar.Add(s[i]);
                listIndex.Add(i);
            }
        }

        listChar.Sort();

        var sb = new StringBuilder(s);

        for(int i = 0; i<listChar.Count(); i++){
            //Console.WriteLine(listChar[i] + " - " + listIndex[i]);

            sb[listIndex[i]] = listChar[i];
        }

        return sb.ToString();
    }

    private bool IsVowel(char c){
        return c is 'a' or 'A' or 'i' or 'I' or 'u' or 'U' or 'e' or 'E' or 'o' or 'O';
    }*/
}