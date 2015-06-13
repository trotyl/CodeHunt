using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int x)
    {
        return Enumerable.Repeat(x, 10).ToArray();
    }
}