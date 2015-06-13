using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int n)
    {
        return String.Join(" ", Enumerable.Range(1, n).Concat(Enumerable.Range(1, n - 1).Reverse()).Select(x => String.Join("", Enumerable.Repeat(x, x))));
    }
}