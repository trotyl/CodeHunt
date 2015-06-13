using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int n)
    {
        return string.Join(" ", Enumerable.Range(1, n).Concat(Enumerable.Range(1, n - 1).Reverse()).Select(x => string.Join("", Enumerable.Repeat(x, x))));
    }
}