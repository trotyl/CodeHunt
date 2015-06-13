using System;
using System.Linq;
public class Program
{
    public static int[][] Puzzle()
    {
        return Enumerable.Repeat(new int[5], 5).ToArray();
    }
}