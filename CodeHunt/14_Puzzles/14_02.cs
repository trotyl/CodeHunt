using System;
public class Program
{
    public static int Puzzle(int x)
    {
        return ((int)(Math.Pow(x, 3)) + x) / 2;
    }
}