using System;
public class Program
{
    public static int Puzzle(int n)
    {
        return n <= 0 ? 0 : ((n - 1) / 2) * ((n - 1) / 2 + 1);
    }
}