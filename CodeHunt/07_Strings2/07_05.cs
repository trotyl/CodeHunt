using System;
public class Program
{
    public static string Puzzle(string a, string b)
    {
        var res = "";
        for (int i = 0; i < a.Length; i++)
            res += i % 2 == 0 ? b[i] : a[i];
        return res;
    }
}