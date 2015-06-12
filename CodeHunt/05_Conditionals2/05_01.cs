using System;
public class Program
{
    public static string Puzzle(string s)
    {
        int l = s.Length;
        return l < 4 ? "short" : l < 8 ? "average" : l < 15 ? "long" : "super long";
    }
}