using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int i)
    {
        return Enumerable.Range(0, i + 1).Reverse().ToArray();
    }
}