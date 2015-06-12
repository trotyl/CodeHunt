using System;
public class Program
{
    public static int Puzzle(string a, string b)
    {
        return Math.Max(a.Length, b.Length);
    }
}