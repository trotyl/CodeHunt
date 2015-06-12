using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int n)
    {
        return string.Join("", Enumerable.Range(0, n + 1).Select(x => string.Join("", Enumerable.Range(0, x + 1)) + new string('_', n - x) + " "));
    }
}