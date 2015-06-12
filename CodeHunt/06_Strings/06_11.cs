using System;
using System.Collections.Generic;
public class Program
{
    public static string Puzzle(int i, int j, string s)
    {
        return s.Substring(i, s.Length - i - 1) + s.Substring(j, s.Length - j - 1);
    }
}