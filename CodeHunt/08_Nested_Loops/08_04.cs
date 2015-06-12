using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int n, string b)
    {
        return string.Join(" ", Enumerable.Repeat(new string(b[0], n), n).Select((x, i) => x.Substring(0, i) + '-' + x.Substring(i + 1, x.Length - i - 1)));
    }
}