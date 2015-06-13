using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers, int x, int y)
    {
        return numbers.Select(t => t == x ? y : t).ToArray();
    }
}