using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[][] input, int i)
    {
        return input.SelectMany(x => x).Count(x => x == i);
    }
}