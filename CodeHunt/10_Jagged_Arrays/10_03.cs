using System;
using System.Linq;
public class Program
{
    public static int[][] Puzzle(int length, int x)
    {
        return Enumerable.Repeat(Enumerable.Repeat(x, length).ToArray(), length).ToArray();
    }
}