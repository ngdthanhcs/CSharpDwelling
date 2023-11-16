using System.Text;

namespace Workout;

public static class FindUniqueBinaryString {
    public static string FindUnique(string[] nums)
    {
        string ans = "";
        for (int i = 0; i < nums.Length; ++i)
        {
            //Console.WriteLine(nums[i][i]);
            ans += nums[i][i] == '0' ? '1' : '0';
        }

        return ans;
    }

    private static StringBuilder XOR(StringBuilder a, string b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = a[i] switch
            {
                '0' => b[i] == '1' ? '1' : '0',
                '1' => b[i] == '0' ? '1' : '0'
            };
        }
        return a; 
    } 
    
    private static StringBuilder BITWISE(StringBuilder a, string b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = a[i] switch
            {
                '0' => b[i] == '1' ? '1' : '0',
                '1' => b[i] == '0' ? '1' : '0'
            };
        }
        return a; 
    } 
}