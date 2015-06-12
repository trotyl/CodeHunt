using System;
public class Program
{
    public static string Puzzle(string a, string b)
    {
        var rel = a.Length - b.Length;
        return (rel >= 0 ? a : "") + (rel <= 0 ? b : "");
    }
}