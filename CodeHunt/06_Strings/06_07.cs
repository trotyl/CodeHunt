using System;
public class Program
{
    public static string Puzzle(string s)
    {
        return s.Substring(s.Length / 2 + 1).ToUpper() + s.Substring(s.Length / 2);
    }
}