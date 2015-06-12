using System;
public class Program
{
    public static string Puzzle(int i, int x)
    {
        return (i % x == 0 ? "" : "not a ") + "multiple of " + x;
    }
}