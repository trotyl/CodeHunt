using System;
public class Program
{
    public static int Puzzle(int n)
    {
        return n * (n + 1) * (n + 2) / 6;
    }
}