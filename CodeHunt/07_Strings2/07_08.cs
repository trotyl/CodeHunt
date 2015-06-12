using System;
public class Program
{
    public static bool Puzzle(string input, string a, string b, string c)
    {
        return input.StartsWith(a) && input.Contains(b) && input.EndsWith(c);
    }
}