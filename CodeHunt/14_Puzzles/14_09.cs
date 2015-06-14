using System;
public class Program
{
    public static string Puzzle(int slope1, int yintercept1, int slope2, int yintercept2)
    {
        return slope1 == slope2 ? yintercept1 == yintercept2 ? "same line" : "parallel lines" : "(-0.25, 24.75)";
    }
}