using System;
using System.Linq;
public class Program
{
    public static int Puzzle(string s)
    {
        return s.Length - s.Replace("a", "").Length;
    }
}