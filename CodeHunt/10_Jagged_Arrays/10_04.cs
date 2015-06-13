using System;
using System.Linq;
public class Program
{
    public static int[][] Puzzle(int[][] input)
    {
        return input.Select(a => a.Select(i => i * 2).ToArray()).ToArray();
    }
}