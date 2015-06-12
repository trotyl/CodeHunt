using System;
using System.Linq;
public class Program
{
    public static bool Puzzle(int a, int b, int c)
    {
        return Math.Pow(Math.Min(a, b), 2) == (Math.Max(a, b) + c) * (Math.Abs(c - Math.Max(a, b)));
    }
}