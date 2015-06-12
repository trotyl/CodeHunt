using System;
using System.Linq;
public class Program
{
    public static int Puzzle(string s, char x)
    {
        return s.Length - s.Replace("" + x, "").Length;
    }
}