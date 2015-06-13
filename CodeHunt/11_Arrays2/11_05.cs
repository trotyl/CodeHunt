using System;
public class Program
{
    public static string[] Puzzle(string[] list)
    {
        var res = new string[(list.Length + 1) / 2];
        int i = 0;
        while (i < list.Length)
        {
            res[i / 2] = list[i] + (i + 1 < list.Length ? list[i + 1] : "");
            i += 2;
        }
        return res;
    }
}