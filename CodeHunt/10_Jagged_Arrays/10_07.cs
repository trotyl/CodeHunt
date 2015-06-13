using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[][] input)
    {
        var max = input.Max(x => x.Sum());
        return input.First(x => x.Sum() == max).ToArray();
    }
}