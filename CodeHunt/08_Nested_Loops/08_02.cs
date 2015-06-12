using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int n)
    {
        return string.Join("", Enumerable.Range(1, n).Select(x => new string('#', x) + " "));
    }
}