using System;
public class Program
{
    public static string Puzzle(int i)
    {
        return (i % 5 == 0 ? "" : "not a ") + "multiple of 5";
    }
}