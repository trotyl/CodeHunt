using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int i, string s)
    {
        return String.Join(" ", Enumerable.Repeat(s, i));
    }
}