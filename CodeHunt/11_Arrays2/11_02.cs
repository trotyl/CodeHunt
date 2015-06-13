using System;
using System.Linq;
public class Program
{
    public static string[] Puzzle(string[] a, int amount)
    {
        return a.Select(x => Enumerable.Repeat(x, amount)).SelectMany(x => x).ToArray();
    }
}