using System;
public class Program
{
    public static string Puzzle(string a, string b)
    {
        int x = a.Length, y = b.Length;
        return x > y ? a : x < y ? b : a + b;
    }
}