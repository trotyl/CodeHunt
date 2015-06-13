using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int h, int w)
    {
        return string.Join(" ", Enumerable.Range(0, h).Select(i => string.Join("", Enumerable.Range(0, w).Select(j => (i + j) % 2 == 0 ? 'x' : 'o'))));
    }
}