using System;
public class Program
{
    public static string Puzzle(int i, int j, int k)
    {
        return (i / (float)j == j / (float)k && (i != j)) ? "yes!" : "no";
    }
}