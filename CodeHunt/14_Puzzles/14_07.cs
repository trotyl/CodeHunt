using System;
using System.Linq;
public class Program
{
    public static bool Puzzle(string s)
    {
        return Enumerable.Range(0, s.Length / 2).All(i => s[i] == s[s.Length - i - 1]);
    }
}