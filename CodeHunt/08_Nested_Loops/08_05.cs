using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string a)
    {
        return string.Join(" ", Enumerable.Repeat(a, a.Length).Select((x, i) => string.Join("", x.Select((y, j) => i == j ? '_' : x[j]))));
    }
}