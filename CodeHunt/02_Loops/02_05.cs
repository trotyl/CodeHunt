using System;
public class Program
{
    public static int Puzzle(int n)
    {
        return (n - 1) * (n) * (2 * n - 1) / 6;
    }
}