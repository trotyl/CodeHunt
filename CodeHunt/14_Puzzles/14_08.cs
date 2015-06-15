using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static bool Puzzle(string a, string b)
    {
        var dic = new int[26];
        for (int i = 0; i < a.Length; i++)
        {
            dic[a[i] - 'a']++;
        }
        for (int i = 0; i < b.Length; i++)
        {
            dic[b[i] - 'a']--;
        }
        return dic.All(x => x == 0);
    }
}