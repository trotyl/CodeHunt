using System;
public class Program
{
    public static int Puzzle(int i)
    {
        return i == 1 ? 1 : i * Puzzle(i - 1);
    }
}