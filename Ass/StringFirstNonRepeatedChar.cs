namespace Ass;

internal static  class StringFirstNonRepeatedChar
{
    public static char FirstNonRepeatedChar(string str)
    {
        int[] freq = new int[26];
        foreach (char c in str)
            freq[c - 'a']++;
        foreach (char c in str)
        {
            if(freq[c - 'a'] == 1)
                return c;
        }
        return ' ';
    }
}